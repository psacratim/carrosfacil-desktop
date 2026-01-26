using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFacil.Database
{ 
    public enum FilterOperator { OR, AND }

    class Filter
    {
        public FilterOperator filterOperator { get; }
        public string column { get; }
        public string value { get; }

        public Filter(string column, string value, FilterOperator filterOperator = FilterOperator.AND)
        {
            this.column = column;
            this.value = value;
            this.filterOperator = filterOperator;
        }
    }


    class QueryBuilder
    {
        private string baseQuery;
        private List<Filter> filters = new List<Filter>();

        public QueryBuilder(string baseQuery)
        {
            this.baseQuery = baseQuery;
        }

        public QueryBuilder AddFilter(string column, string value, FilterOperator filterOperator)
        {
            this.filters.Add(new Filter(column, value, filterOperator));
            return this;
        }
        public QueryBuilder AddFilters(Filter[] filters)
        {
            this.filters.AddRange(filters);
            return this;
        }

        public (string sql, MySqlParameter[] parameters) Build()
        {
            string sql = this.baseQuery;
            var parameterList = new List<MySqlParameter>();

            if (this.filters.Count > 0)
            {
                sql += this.baseQuery.ToUpper().Contains("WHERE") ? " AND" : " WHERE";

                for (int index = 0; index < this.filters.Count; index++)
                {
                    var filter = this.filters[index];
                    string paramName = "@p" + index; // Usa o index pra garantir que os parametros são únicos.

                    sql += string.Format(" {0} = {1}", filter.column, paramName);

                    parameterList.Add(new MySqlParameter(paramName, filter.value));

                    if (index < this.filters.Count - 1)
                    {
                        sql += " " + (filter.filterOperator == FilterOperator.OR ? "OR" : "AND");
                    }
                }
            }

            return (sql, parameterList.ToArray());
        }
    }
}

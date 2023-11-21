﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDataBase
{
    public class SQLCrud<T> where T : Usuario
    {
        private string _tableName;
        private string[] _columnas;

        public SQLCrud(string tableName, string[] columnas)
        {
            _tableName = tableName;
            _columnas = columnas;
        }

        public List<T> GetAll()
        {
            return DB.Select<T>(PrepareSelectQuery());
        }

        private string PrepareSelectQuery()
        {
            var cols = string.Join(",", _columnas);
            var query = $"SELECT {cols} FROM {_tableName}";
            return query;
        }
    }
}

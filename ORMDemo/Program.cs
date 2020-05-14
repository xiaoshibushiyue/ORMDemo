using ORMDemo.DAL;
using ORMDemo.Model;
using System;

namespace ORMDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlHelper sqlHelper = new SqlHelper();
                CompanyModel company = sqlHelper.Find<CompanyModel>(1);
                sqlHelper.Insert<CompanyModel>(company);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()) ;
            }
            Console.ReadLine();
        }
    }
}

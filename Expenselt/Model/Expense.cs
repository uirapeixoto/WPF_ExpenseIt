﻿
namespace Expenselt.Model
{
    public class Expense
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public string ExpenseType{ get; set; }
        public int ExpenseAmount{ get; set; }
    }
}

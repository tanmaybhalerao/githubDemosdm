using System;

namespace Banking
{

    class Account 
    {
       private double balance;
        private readonly int id;
        private string holder;
        //default constructor
        //function overloading
        public Account() 
        {

        }
        //parametric constructor
        public Account(int id, double amount, string holder) 
        {
            this.balance = amount;
            this.id = id;
            this.holder = holder;
        }

        public void Withdraw(double amount) 
        {
            if (balance-amount  >5000 ) 
            this.balance = this.balance - amount;
           
        }  
        public void Deposit(double amount) 
        {
            this.balance = this.balance + amount;
        }

        public override string ToString()
        {
            return this.holder + "----------------" + this.balance + "-------------" + this.id;
        }


        //getter and setter method normal way
        public int Getid() 
        {
            return this.id;
        }

        //getter and setter by proppertise
        public double Balance 
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        
    }

    class Manager
    {
        public static void Main(string [] args) 
        {
            Account acc1 = new Account(1, 10000, "somay");
            Account acc2 = new Account(2, 15000, "Tanmay");
            acc1.ToString();
            Console.WriteLine("before deposit"+acc1);
            acc1.Deposit(312);
            acc2.Deposit(212);
            Console.WriteLine("id of acc1 is: "+acc1.Getid());


            Console.WriteLine("after deposit"+acc1);
            Console.WriteLine("Get balance of acc2:"+acc2.Balance);//getter
            acc2.Balance=2000;//setter
            Console.WriteLine("Get balance of acc2:"+acc2.Balance);//getter

            Console.ReadLine();
        }
        
    }
}


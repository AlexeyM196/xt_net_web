using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._3_Piza_Time
{
    public enum PizzaTypes
    {
        Margarita,
        Hawaiian,
        Peperoni
    }

    public class Pizza
    {
        public PizzaTypes PizzaType { get; set; }
        public int CookingTime { get; set; }

        public Pizza(PizzaTypes pizzaType)
        {
            PizzaType = pizzaType;
        }
    }

    class Order
    {
        public string CustomerName { get; }
        public PizzaTypes PizzaType { get; }
        public bool Completed { get; set; }

        public Order(string customerName, PizzaTypes PizzaType)
        {
            CustomerName = customerName;
            this.PizzaType = PizzaType;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public Customer(string name)
        {
            Name = name;
        }
    }

    class ReadyPizzaEvent : EventArgs
    {
        public Order CompleteOrder { get; set; }

        public ReadyPizzaEvent(Order order)
        {
            CompleteOrder = order;
        }
    }

    class Pizzeria
    {
        Dictionary<Order, Pizza> completeOrders = new Dictionary<Order, Pizza>();

        public event EventHandler PizzaReadyToEat;

        protected virtual void OnPizzaReadyToEat(ReadyPizzaEvent x)
        {
            EventHandler handler = PizzaReadyToEat;
            handler?.Invoke(this, x);
        }

        private async Task MakePizzaAsync(Order order)
        {
            await Task.Delay(2000);
            Pizza pizza = new Pizza(order.PizzaType);
            order.Completed = true;
            completeOrders.Add(order, pizza);
            OnPizzaReadyToEat(new ReadyPizzaEvent(order));
        }

        public Order MakeOrder(String customer, PizzaTypes pizzaType)
        {
            Order order = new Order(customer, pizzaType);
            MakePizzaAsync(order);
            return order;
        }

        public Pizza GetPizza(Order order)
        {
            if (order.Completed)
            {
                Pizza pizza = null;
                completeOrders.TryGetValue(order, out pizza);
                completeOrders.Remove(order);
                return pizza;
            }
            return null;
        }
    }
    class Program
    {
        public static Pizzeria MyPizzeria;
        public static Customer me;
        static void Main(string[] args)
        {
            MyPizzeria = new Pizzeria();
            MyPizzeria.PizzaReadyToEat += c_PizzaIsReadyToEat;
            Console.WriteLine("Введите имя:");
            string str = Console.ReadLine();
            me = new Customer(str);
            Order order = MyPizzeria.MakeOrder(me.Name, PizzaTypes.Peperoni);
            Console.WriteLine("{0} has ordered Pizza {1}.", me.Name, PizzaTypes.Peperoni);
            System.Threading.Thread.Sleep(10000);
        }

        static void c_PizzaIsReadyToEat(object sender, EventArgs x)
        {
            ReadyPizzaEvent rpe = (ReadyPizzaEvent)x;
            Console.WriteLine("Pizza is ready for: " + rpe.CompleteOrder.CustomerName);
        }
    }
}

using System;

namespace NGuava
{
    /// <summary>
    /// Subscribers that would like to declare a method as handler for a specific message, should add 
    /// this attribute to the method decleration.
    /// 
    /// <example>
    /// public class ConsoleLogger
    /// {
    ///     [Subscribe]
    ///     public void OnPurchase(IPurchaseEvent purchase)
    ///     {
    ///         Console.WriteLine(purchase.GetAmount());
    ///     }
    ///     
    ///     // subscribe with priority higher than default 0
    ///     [Subscribe(10)]
    ///     public void OnPurchase(IPurchaseEvent purchase)
    ///     {
    ///         Console.WriteLine(purchase.GetAmount());
    ///     }
    /// }
    /// </example>
    /// Please notice the following:
    /// a.The return type of the subscribed method is irellevant and generally should be void.
    /// b.The method must have one and only one parameter, and its type determines 
    /// the event type.
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Method , AllowMultiple = false)]
    public class Subscribe : Attribute
    {
        /// <summary>
        /// Priority of subscriber - higher priority means that event will be propagated sooner then to other with lower priority
        /// </summary>
        private int priority;

        /// <summary>
        /// Constructor with default priority of 0
        /// </summary>
        /// <param name="priority">Priority of subscriber - higher priority means that event will be propagated sooner then to other with lower priority</param>
        public Subscribe(int priority = 0)
        {
            this.priority = priority;
        }

        public int GetPriority()
        {
            return priority;
        }
    }
}

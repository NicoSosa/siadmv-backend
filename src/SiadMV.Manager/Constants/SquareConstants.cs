namespace SiadMV.Manager.Constants
{
    public struct SquareConstants
    {
        public const string Access = "square:access"; 
        public const string Uri = "square:uri"; 

        public struct EndPoints
        {
            public struct Customer
            {
                public const string CreateCustomer = "square:endpoint:customer:createCustomer";
                public const string SearchCustomers = "square:endpoint:customer:searchCustomers";
                public const string DeleteCustomer = "square:endpoint:customer:deleteCustomer";
                public const string RetrieveCustomer = "square:endpoint:customer:retrieveCustomer";
                public const string UpdateCustomer = "square:endpoint:customer:updateCustomer";
                public const string CreateCustomerCard = "square:endpoint:customer:createCustomerCard";
                public const string DeleteCustomerCard = "square:endpoint:customer:deleteCustomerCard";

            }

            public struct Payment
            {
                public const string ListPayment = "square:endpoint:payment:listPayments";
                public const string CreatePayment = "square:endpoint:payment:createPayment";
                public const string CancelPaymentByIdempotencyKey = "square:endpoint:payment:cancelPaymentByIdempotencyKey";
                public const string GetPayment = "square:endpoint:payment:getPayment";
            }
        }
    }
}

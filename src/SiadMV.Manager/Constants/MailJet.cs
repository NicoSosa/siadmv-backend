namespace SiadMV.Manager.Constants
{
    public struct MailJet
    {
        public const string ApiKey = "mailjet:apiKey";
        public const string SecretKey = "mailjet:secretKey";
        public const string Uri = "mailjet:uri";
        public const string SandboxEnabled = "mailjet:sandboxEnabled";
        public const string SenderEmailAddress = "mailjet:sender:emailAddress";
        public const string SenderName = "mailjet:sender:name";

        public struct Endpoints
        {
            public const string GetContact = "mailjet:endpoint:getContact";
            public const string CreateUpdateContact = "mailjet:endpoint:createUpdateContact";
            public const string UpdateContactEmailAddress = "mailjet:endpoint:updateContactEmailAddress";
            public const string GetContactLists = "mailjet:endpoint:getContactLists";
            public const string RetrieveAllContactLists = "mailjet:endpoint:retrieveAllContactLists";
            public const string SendEmail = "mailjet:endpoint:sendEmail";
        }

        public struct Templates
        {
            public const string TemplateIdOrderReceived = "mailjet:templateId:orderReceived";
            public const string TemplateIdOrderReady = "mailjet:templateId:orderReady";
            public const string TemplateIdOrderOnRoute = "mailjet:templateId:orderOnRoute";
        }
    }
}

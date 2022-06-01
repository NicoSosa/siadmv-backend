namespace SiadMV.DataAccess.Seeds.Constants
{
    public struct UserCaseConst
    {
        public struct First
        {
            public const string Id = "8C8DEEAD-324B-429F-A283-4CC48C51305D";
            public const string Description = "Una organización de alrededor de 60 usuarios requiere un sistema de control de asistencia, el mismo debe ser web y accedido por la red interna de la empresa, se solicita que el frontend sea elaborado en PHP y el backend utiliza una base de datos. Además se solicita poder realizar una rápida recuperación en caso de un evento inesperado.";
        }
        public struct Second
        {
            public const string Id = "E21D8BFC-F99A-493A-A76E-5C53342CA8AD";
            public const string Description = "Aplicación instalada en dispositivos móviles Android utilizados por personal que realiza la toma de datos de clientes de la empresa fuera de esta, esta aplicación accede a una base de datos MS SQLServer, mediante webservices ejecutados en el mismo servidor intercambian información con el aplicativo de negocios.";
        }
        public struct Third
        {
            public const string Id = "A134D0CB-89CE-4FCE-B0D0-95069F927FF5";
            public const string Description = "Servicios de autenticación y almacenamiento de archivos común a toda la organización, la estructura de dominio es utilizada para autenticar varios servicios incluido el acceso a los diferentes aplicativos, el almacenamiento de archivos está formado por varios directorios compartidos según áreas con los permisos NTFS correspondientes por grupos y/o usuarios.";
        }

    }
}

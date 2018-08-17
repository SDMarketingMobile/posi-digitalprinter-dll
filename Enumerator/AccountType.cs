using System;

namespace POSIDigitalPrinterAPIUtil.Enumerator
{
    public enum AccountType
    {
        SALAO = 1,
        VIAGEM = 2,
        DRIVE = 3,
        DELIVERY = 4,
        FESTA = 5,
        BALCAO = 6,
        SELF = 7,
        FAST = 8,
        QUIOSQUE = 9,
        SELF_NAO_CONCOMITANTE = 12,
        CARTAO = 14
    }

    public static class AccountTypeExtensions
    {
        public static int GetCodigo(this AccountType type)
        {
            switch(type)
            {
                case AccountType.SALAO:
                    return 1;
                case AccountType.VIAGEM:
                    return 2;
                case AccountType.DRIVE:
                    return 3;
                case AccountType.DELIVERY:
                    return 4;
                case AccountType.FESTA:
                    return 5;
                case AccountType.BALCAO:
                    return 6;
                case AccountType.SELF:
                    return 7;
                case AccountType.FAST:
                    return 8;
                case AccountType.QUIOSQUE:
                    return 9;
                case AccountType.SELF_NAO_CONCOMITANTE:
                    return 12;
                case AccountType.CARTAO:
                    return 14;
                default:
                    return 0;
            }
        }

        public static AccountType FromCodigo(int code)
        {
            foreach(AccountType aux in Enum.GetValues(typeof(AccountType)))
            {
                if (aux.GetCodigo().Equals(code))
                {
                    return aux;
                }
            }
            return 0;
        }

        public static string GetName(this AccountType type)
        {
            switch (type)
            {
                case AccountType.SALAO:
                    return "SALAO";
                case AccountType.VIAGEM:
                    return "VIAGEM";
                case AccountType.DRIVE:
                    return "DRIVE";
                case AccountType.DELIVERY:
                    return "DELIVERY";
                case AccountType.FESTA:
                    return "FESTA";
                case AccountType.BALCAO:
                    return "BALCAO";
                case AccountType.SELF:
                    return "SELF";
                case AccountType.FAST:
                    return "FAST";
                case AccountType.QUIOSQUE:
                    return "QUIOSQUE";
                case AccountType.SELF_NAO_CONCOMITANTE:
                    return "SELF NAO CONCOMITANTE";
                case AccountType.CARTAO:
                    return "CARTAO";
                default:
                    return null;
            }
        }
    }
}

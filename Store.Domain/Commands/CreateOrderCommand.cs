using Flunt.Notifications;
using Flunt.Validations;
using Store.Domain.Commands.Intefaces;
using System.Collections.Generic;

namespace Store.Domain.Commands
{
    public class CreateOrderCommand : Notifiable, ICommand
    {
        public string Custormer { get; set; }
        public string ZipCode { get; set; }
        public string PromoCode { get; set; }
        public IList<CreateOrderItemCommand> Items { get; set; }

        public CreateOrderCommand()
        {
            Items = new List<CreateOrderItemCommand>();
        }

        public CreateOrderCommand(string custormer, string zipCode, string promoCode, IList<CreateOrderItemCommand> items)
        {
            Custormer = custormer;
            ZipCode = zipCode;
            PromoCode = promoCode;
            Items = items;
        }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasLen(Custormer, 11, "Customer", "Cliente inválido")
                .HasLen(ZipCode, 8, "ZipCode", "Cep inválido"));
        }
    }
}

using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Banking.Domain.Events
{
	/// <summary>
	/// Esto es la Data que voy a enviar al RabbitMQ
	/// </summary>
	public class TransferCreateEvent : Event
	{
		public int From { get; set; }
		public int To { get; set; }

		public decimal Amount { get; set; }

		public TransferCreateEvent(int from, int to, decimal amount)
		{
			From= from;
			To= to;
			Amount= amount;
		}

	}
}

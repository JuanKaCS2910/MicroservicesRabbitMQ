using MediatR;

namespace MicroRabbit.Domain.Core.Events
{
	public abstract class Message : IRequest<bool>
	{

		public string MessageType { get; protected set; }

		protected Message()
		{
			//El GetType hace referencia al nombre de la clase que está ejecutando este Message.
			MessageType = GetType().Name;
		}

	}
}

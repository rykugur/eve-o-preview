using System.Threading;
using System.Threading.Tasks;
using EveOPreview.Mediator.Messages;
using EveOPreview.Services;
using MediatR;

namespace EveOPreview.Mediator.Handlers.Services
{
	sealed class StartStopServiceHandler : IRequestHandler<StartService>, IRequestHandler<StopService>
	{
		private readonly IThumbnailManager _manager;

		public StartStopServiceHandler(IThumbnailManager manager)
		{
			this._manager = manager;
		}

		public Task<Unit> Handle(StartService message, CancellationToken cancellationToken)
		{
			this._manager.Start();

            return Task.FromResult(Unit.Value);
		}

		public Task<Unit> Handle(StopService message, CancellationToken cancellationToken)
		{
			this._manager.Stop();

            return Task.FromResult(Unit.Value);
		}
	}
}
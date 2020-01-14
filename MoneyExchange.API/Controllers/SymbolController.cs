using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoneyExchange.Application.Symbols.Commands.CreateSymbol;
using MoneyExchange.Application.Symbols.Queries.GetSymbolsList;

namespace MoneyExchange.API.Controllers
{
    public class SymbolController: BaseController
    {
        [HttpGet]
        public async Task<ActionResult<SymbolsListVm>> GetAll()
        {
            return Ok(await Mediator.Send(new GetSymbolsListQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateSymbolCommand command)
        {
            var symbolId =await Mediator.Send(command);
            return Ok(symbolId);
        }
    }
}
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGameApiVisa.Data;
using VideoGameApiVisa.Entities;

namespace VideoGameApiVisa.Features.VideoGames
{
    public static class GetAllGames
    {
        public record Query : IRequest<IEnumerable<Response>>;

        public record Response(int Id, string Title, string Genre, int ReleaseYear);

        public class Handler(VideoGameDbContext context) : IRequestHandler<Query, IEnumerable<Response>>
        {
            public async Task<IEnumerable<Response>> Handle(Query request, CancellationToken cancellationToken)
            {
                var games = await context.VideoGames.ToListAsync(cancellationToken);
                return games.Select(game => new Response(game.Id, game.Title, game.Genre ?? string.Empty, game.ReleaseYear));
            }
        }
    }


    [ApiController]
    [Route("api/games")]
    public class GetAllGamesController(ISender sender) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetAllGames.Response>>> GetAllGames()
        {
            var response = await sender.Send(new GetAllGames.Query());
            return Ok(response);
        }
    }

}

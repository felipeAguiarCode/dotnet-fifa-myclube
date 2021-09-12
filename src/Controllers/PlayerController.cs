using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using fifa_my_club.Models;

namespace fifa_my_club.Controllers
{

//GET - Buscar informações (select)
//POST - Enviar informações (envia)
//DELETE - delete
//PUT - update

    [ApiController]
    [Route("api/v1/players")]
    public class PlayerController : ControllerBase
    {
        
        [HttpGet("id:int")]
        public Player GetPlayer(int id){

            Player myPlayer = new Player(
                id,
                "Marquinhos", 
                78, 
                82, 
                72, 
                79, 
                47, 
                75
            );

            return myPlayer;
        }
    }
}
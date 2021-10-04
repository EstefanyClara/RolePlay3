using System.Collections.Generic; 

namespace RoleplayGame
{
    public class Encounter
    {
        //Armo dos listas en donde voy a guardar los personajes heroes y enemigos que se van a enfrentar
        private List<Hero> listaHeroes= new List<Hero>(); 
        private List<Enemy> listaEnemigos =new List<Enemy>();

        //agrego heroes a la lista
        public void personajesHeroes(Hero hero)
        {
            this.listaHeroes.Add(hero); 
        }
        
        //agrego enemigos a la lista 
         public void personajeEnemigos(Enemy enemy)
        {
            this.listaEnemigos.Add(enemy); 
        }
        
        //metodo para ejecutar 
       /* public void doEncounters()
        {
            while (listaEnemigos.Count !=0 && listaHeroes.Count != 0 )
            {
                for( int i=0; i<this.listaEnemigos.Count; i++)
                {
                    Hero ReceiveAttack = this.listaEnemigos[i];
                }
            }
        }*/

    }
}

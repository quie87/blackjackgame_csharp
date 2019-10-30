using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BlackJack.controller
{
    class PlayGame : model.ICardsDealtObserver
    {
        private view.IView a_view;
        private model.Game a_game;
        public PlayGame(model.Game a_game, view.IView a_view)
        {
            this.a_view = a_view;
            this.a_game = a_game;
            a_game.AddSubscribers(this);
        }
        public bool Play()
        {
            UpdateCards();
            
            if (a_game.IsGameOver())
            {
                a_view.DisplayGameOver(a_game.IsDealerWinner());
            }

            view.MenuOptions input = a_view.GetInput();

            if (input == view.MenuOptions.Play)
            {
                a_game.NewGame();
            }
            else if (input == view.MenuOptions.Hit)
            {
                a_game.Hit();
            }
            else if (input == view.MenuOptions.Stand)
            {
                a_game.Stand();
            }

            return input != view.MenuOptions.Quit;
        }

        public void UpdateCards()
        {
            Thread.Sleep(1000);
            a_view.DisplayWelcomeMessage();

            a_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            a_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());
        }
    }
}

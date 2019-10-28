using System;

namespace BlackJack.model.rules

{
    interface WinRules
    {
        bool WhoWin(int a_playerScore, int a_dealerScore, int a_maxScore);
    }
}
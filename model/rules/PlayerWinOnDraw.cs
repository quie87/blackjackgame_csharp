using System;

namespace BlackJack.model.rules
{
    class PlayerWinOnDraw : WinRules
    {
        public bool WhoWin(int m_playerScore, int m_dealerScore, int m_maxScore)
        {
            if (m_playerScore > m_maxScore)
            {
                return true;
            }
            else if (m_dealerScore > m_maxScore)
            {
                return false;
            }
            return m_dealerScore > m_playerScore;
        }
    }
}
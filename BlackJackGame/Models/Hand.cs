using System;
using System.Collections.Generic;

namespace BlackJackGame.Models
{
    public class Hand
    {
        #region Fields
        private readonly IList<BlackJackCard> _cards;
        #endregion

        #region Properties
        public IEnumerable<BlackJackCard> Cards { get { throw new NotImplementedException(); } }

        public int NrOfCards { get { throw new NotImplementedException(); } }

        public int Value { get { throw new NotImplementedException(); } }
        #endregion

        #region Constructors
        public Hand()
        {
            _cards = new List<BlackJackCard>();
        }
        #endregion

        #region Methods
        public void AddCard(BlackJackCard blackJackCard)
        {
            throw new NotImplementedException();
        }

        public void TurnAllCardsFaceUp()
        {
            throw new NotImplementedException();
        }
        private int CalculateValue()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
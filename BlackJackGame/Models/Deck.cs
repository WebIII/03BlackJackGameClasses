using System;
using System.Collections.Generic;

namespace BlackJackGame.Models
{
    public class Deck
    {
        #region Fields
        private static readonly Random _random = new Random();
        protected  IList<BlackJackCard> _cards;
        #endregion

        #region Constructors
        public Deck()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods
        private void Shuffle()
        {
            throw new NotImplementedException();
        }

        public BlackJackCard Draw()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
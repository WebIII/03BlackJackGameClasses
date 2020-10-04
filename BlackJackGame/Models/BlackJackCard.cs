using System;

namespace BlackJackGame.Models
{
    public class BlackJackCard : Card
    {
        #region Properties
        public bool FaceUp { get; private set; }

        public int Value
        {
            get { throw new NotImplementedException(); }
        }
        #endregion

        #region Constructors
        public BlackJackCard(Suit suit, FaceValue faceValue)
            : base(suit, faceValue)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods
        public void TurnCard()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
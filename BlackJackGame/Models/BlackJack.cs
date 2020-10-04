using System;

namespace BlackJackGame.Models
{
    public class BlackJack
    {
        #region Fields
        public const bool FaceDown = false;
        public const bool FaceUp = true;
        private readonly Deck _deck;
        #endregion

        #region Properties
        public GameState GameState { get; private set; }
        public Hand DealerHand { get; private set; }
        public Hand PlayerHand { get; private set; }
        #endregion

        #region Constructors
        public BlackJack() : this(new Deck()) {
            throw new NotImplementedException();
        }

        public BlackJack(Deck deck)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods
        private void Deal()
        {
            throw new NotImplementedException();
        }

        public void GivePlayerAnotherCard()
        {
            throw new NotImplementedException();
        }

        public void PassToDealer()
        {
            throw new NotImplementedException();
        }
        private void LetDealerFinalize()
        {
            throw new NotImplementedException();
        }

        private void AdjustGameState(GameState? gameState = null)
        {
            throw new NotImplementedException();
        }

        private void AddCardToHand(Hand hand, bool faceUp)
        {
            throw new NotImplementedException();
        }

        public string GameSummary()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
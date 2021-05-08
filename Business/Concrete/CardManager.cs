using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CardManager : ICardService
    {

        ICardDal _cardDal;
        public CardManager(ICardDal cardDal)
        {
            _cardDal = cardDal;
        }
        [ValidationAspect(typeof(CardValidator))]
        public IResult Add(Card card)
        {
            _cardDal.Add(card);
            return new SuccessResult(Messages.CardAdded);
        }

        public IResult Delete(Card card)
        {
            _cardDal.Delete(card);
            return new SuccessResult(Messages.CardDeleted);
        }

        public IDataResult<List<Card>> GetAll()
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetAll());
        }

        public IDataResult<Card> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<Card>(_cardDal.Get(c => c.CustomerId == customerId));
        }

        public IDataResult<Card> GetById(int id)
        {
            return new SuccessDataResult<Card>(_cardDal.Get(p=>p.CardId==id));
        }

        public IResult IsCardExist(Card card)
        {
            var result = _cardDal.Get(c => c.CardOwnerName== card.CardOwnerName &&c.ExpirationDate==card.ExpirationDate &&c.CardNumber == card.CardNumber && c.CardCvv == card.CardCvv);
            if (result == null)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        [ValidationAspect(typeof(CardValidator))]
        public IResult Update(Card card)
        {
            _cardDal.Update(card);
            return new SuccessResult(Messages.CardUpdated);
        }
    }
}

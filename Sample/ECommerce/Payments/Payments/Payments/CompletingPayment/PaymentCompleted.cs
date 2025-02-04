using System;
using Ardalis.GuardClauses;
using Core.Events;

namespace Payments.Payments.CompletingPayment
{
    public class PaymentCompleted: IEvent
    {
        public Guid PaymentId { get; }

        public DateTime CompletedAt { get; }

        private PaymentCompleted(Guid paymentId, DateTime completedAt)
        {
            PaymentId = paymentId;
            CompletedAt = completedAt;
        }

        public static PaymentCompleted Create(Guid paymentId, DateTime completedAt)
        {
            Guard.Against.Default(paymentId, nameof(paymentId));
            Guard.Against.Default(completedAt, nameof(completedAt));

            return new PaymentCompleted(paymentId, completedAt);
        }
    }
}

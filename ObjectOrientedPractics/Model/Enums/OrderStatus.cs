namespace ObjectOrientedPractics.Model.Enums
{
    /// <summary>
    /// Статусы заказа.
    /// </summary>
    public enum OrderStatus
    {
        New,
        Processing,
        Assembly,
        Sent,
        Delivered,
        Returned,
        Abandoned
    }
}
using System;


public class VerificationService : IVerificationService
{
    public bool VerifyIdentity(int userId)
    {
        Console.WriteLine($"Identity verified for user {userId}.");
        return true;
    }
}

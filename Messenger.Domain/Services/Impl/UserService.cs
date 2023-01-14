﻿using Messenger.Domain.Models;
using Messenger.Domain.Repositories;

namespace Messenger.Domain.Services.Impl;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IEncryptionService _encryptionService;

    public UserService(IUserRepository userRepository, IEncryptionService encryptionService)
    {
        _userRepository = userRepository;
        _encryptionService = encryptionService;
    }

    public async Task<int?> CreateUserAsync(User user, string password)
    {
        var encryptedPassword = await _encryptionService.EncryptString(password);
        return await _userRepository.CreateUserAsync(user, encryptedPassword);
    }

    public async Task<User?> GetUserByEmailAsync(string email)
    {
        // TODO: избавиться от затычки
        return null;
    }

    public Task<User?> GetUserByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CheckUserPasswordAsync(User user, string password)
    {
        // TODO: избавиться от затычки
        return Task.FromResult(true);
    }
}
using AutoMapper;
using Business.Abstract;
using Business.Configuration.Auth;
using Business.Configuration.Response;
using Business.Configuration.Validator.FluentValidation;
using DAL.Abstract;
using DTO.Payment;
using DTO.User;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public CommandResponse Register(CreateUserRegisterRequest register)
        {

            var validator = new CreateUserRegisterRequestValidator();
            validator.Validate(register);

            byte[] passwordHash, passwordSalt;
            HashHelper.CreatePasswordHash(register.UserPassword, out passwordHash, out passwordSalt);

            var user = _mapper.Map<User>(register);

            user.Password = new UserPassword()
            {
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            _userRepository.Add(user);
            _userRepository.SaveChanges();

            return new CommandResponse()
            {
                Message = "User added successfully",
                Status = true
            };


        }


    }
}

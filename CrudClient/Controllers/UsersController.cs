using System.Collections.Generic;
using AutoMapper;
using CrudClient.Data;
using CrudClient.Dtos;
using CrudClient.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudClient.Controllers
{
    // api/users
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<UserReadDtos>> GetAllUsers()
        {
            var userItems = _repository.GetAllUsers();

            return Ok(_mapper.Map<IEnumerable<UserReadDtos>>(userItems));
        }

        [HttpGet("{id}", Name = "GetUserById")]
        public ActionResult <UserReadDtos> GetUserById(int id)
        {
            var userItem = _repository.GetUserById(id);

            if(userItem != null)
                return Ok(_mapper.Map<UserReadDtos>(userItem));
            
            return NotFound();
        }

        // POST api/users
        [HttpPost]
        public ActionResult <UserReadDtos> CreateUser(CreateUserDtos userCreate)
        {
            var userModel = _mapper.Map<User>(userCreate);
            _repository.CreateUser(userModel);
            _repository.SaveChanges();
            // return Ok(userModel);

            var userReadDto = _mapper.Map<UserReadDtos>(userModel);
            return CreatedAtRoute(nameof(GetUserById), new {Id = userReadDto.Id}, userReadDto);
        }

        // PUT api/users/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateUser(int id, UpdateUserDtos updateUserDtos)
        {
            var userModelFromRepo = _repository.GetUserById(id);

            if(userModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(updateUserDtos, userModelFromRepo);

            _repository.UpdateUser(userModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            var userModelFromRepo = _repository.GetUserById(id);

            if(userModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteUser(userModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
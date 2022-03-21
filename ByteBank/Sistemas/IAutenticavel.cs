using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public interface IAutenticavel // interface implementation 
    {
        //CONTRACT
         bool Autenticar(string senha); // structure of interface member. It has all members public and it does not contain implementations 
                                        //An interface defines a contract. Any class or struct that implements that contract must provide an implementation of the members defined in the interface.
    }
}

﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using MernisServiceReference;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        //encapsulation
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,Ad:person.FirstName,person.LastName,DogumYili:person.DateOfBirtYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }


    }
}

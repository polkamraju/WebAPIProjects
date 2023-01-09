using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebAPIProjects_Task1_Helper;

namespace WebAPIProjects_Task1_Helper
{
   public class ArthimeticCalculator //: IArthimeticCalculator
    {
        private string _firstNumber;
        private string _secondNumber;


        public ArthimeticCalculator(string firstNumber, string secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
        }

        #region Synchronous Methods

        #endregion
        public Response AddTwoNumbers()
        {
            int parsedFirstNumber, parsedSecondNumber, result = 0;
            try
            {
                bool isFirstNumberParseSuccess = int.TryParse(_firstNumber, out parsedFirstNumber);
                bool isSecondNumberParseSuccess = int.TryParse(_secondNumber, out parsedSecondNumber);
                Response response;
                if (isFirstNumberParseSuccess && isSecondNumberParseSuccess)
                {
                    result = parsedFirstNumber + parsedSecondNumber;
                    response = new Response { Status = "Success", Message = "The sum of two numbers is : " + result };
                }
                else
                {
                    response = new Response { Status = "Not Success", Message = "Please enter two Valid numbers" };
                }
                return response;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Response SubtractTwoNumbers()
        {
            int parsedFirstNumber, parsedSecondNumber, result = 0;
            try
            {
               bool isFirstNumberParseSuccess = int.TryParse(_firstNumber, out parsedFirstNumber);
                bool isSecondNumberParseSuccess = int.TryParse(_secondNumber, out parsedSecondNumber);
                Response response;
                if (isFirstNumberParseSuccess && isSecondNumberParseSuccess)
                {
                    result = parsedFirstNumber  - parsedSecondNumber;
                    response = new Response { Status = "Success", Message = "The difference of two numbers is : " + result };
                }
                else
                {
                    response = new Response { Status = "Not Success", Message = "Please enter two Valid numbers" };
                }
                return response;
            }
            catch (Exception)
            {

                throw;
            }

        }

        #region Asynchronous Methods
        public Task<Response> AddTwoNumbersAsync()
        {
            int parsedFirstNumber, parsedSecondNumber, result = 0;
            try
            {
                bool isFirstNumberParseSuccess = int.TryParse(_firstNumber, out parsedFirstNumber);
                bool isSecondNumberParseSuccess = int.TryParse(_secondNumber, out parsedSecondNumber);
                Response response;
                if (isFirstNumberParseSuccess && isSecondNumberParseSuccess)
                {
                    result =  parsedFirstNumber + parsedSecondNumber;
                    response =  new Response { Status = "Success", Message = "The sum of two numbers is : " + result };
                }
                else
                {
                    response = new Response { Status = "Not Success", Message = "Please enter two Valid numbers" };
                }
                return Task.FromResult(response);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<Response> SubtractTwoNumbersAsync()
        {
            int parsedFirstNumber, parsedSecondNumber, result = 0;
            try
            {
                bool isFirstNumberParseSuccess = int.TryParse(_firstNumber, out parsedFirstNumber);
                bool isSecondNumberParseSuccess = int.TryParse(_secondNumber, out parsedSecondNumber);
                Response response;
                if (isFirstNumberParseSuccess && isSecondNumberParseSuccess)
                {
                    result = parsedFirstNumber - parsedSecondNumber;
                    response = new Response { Status = "Success", Message = "The difference of two numbers is : " + result };
                }
                else
                {
                    response = new Response { Status = "Not Success", Message = "Please enter two Valid numbers" };
                }
                return Task.FromResult(response);
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}

namespace CoexWorkshop
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Week1
    {
        public static List<string> RegexValidation(string id)
        {
            List<string> errors = new();
            var firtLetterPattern = "^[A-Z]";
            var lengthPattern = ".{4,32}$";

            if (string.IsNullOrEmpty(id))
            {
                errors.Add($"{nameof(id)} is null");
                return errors;
            }

            if (Regex.Match(id, $"{firtLetterPattern}{lengthPattern}").Success)
            {
                return errors;
            }

            if (!Regex.Match(id, firtLetterPattern).Success)
            {
                errors.Add($"The first letter of the {nameof(id)} is not in uppercase");
            }

            var lengthMatch = Regex.Match(id.Remove(0, 1), "^.{0,}$");

            if (lengthMatch.Length < 5)
            {
                errors.Add($"The {nameof(id)} length is lower than 5");
            }
            else
            {
                errors.Add($"The {nameof(id)} length is higger than 32");
            }

            return errors;
        }

        public static List<string> IfValidation(string id)
        {
            List<string> errors = new();

            if (string.IsNullOrEmpty(id))
            {
                errors.Add($"{nameof(id)} is null");
                return errors;
            }

            if (!char.IsUpper(id.ToCharArray()[0]))
            {
                errors.Add($"The first letter of the {nameof(id)} is not in uppercase");
            }

            var idLength = id.Length;

            if (!(idLength >= 5 && idLength <= 32))
            {
                if (idLength < 5)
                {
                    errors.Add($"The {nameof(id)} length is lower than 5");
                }
                else
                {
                    errors.Add($"The {nameof(id)} length is higger than 32");
                }
            }

            return errors;
        }

        public static void ExceptionsValidation(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("Is null", nameof(id));
            }

            if (!char.IsUpper(id.ToCharArray()[0]))
            {
                throw new ArgumentException($"The first letter of the {nameof(id)} is not in uppercase");
            }

            var idLength = id.Length;

            if (!(idLength >= 5 && idLength <= 32))
            {
                if (idLength < 5)
                {
                    throw new ArgumentException($"The {nameof(id)} length is lower than 5");
                }
                else
                {
                    throw new ArgumentException($"The {nameof(id)} length is higger than 32");
                }
            }
        }
    }
}

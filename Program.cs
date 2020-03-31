using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    //enum DefibliratorFields : int
    //{
    //    ORGANIZATION = 0,
    //    ADDRESS,
    //    LONGITUDE,
    //    LATITUDE
    //};
    class Program
    {
        //private struct Position
        //{
        //    public bool Parse(string[] data)
        //    {
        //        bool isParsingSuccusful = ParseLongitude(data[(int)DefibliratorFields.LONGITUDE]) && ParseLatitude(data[(int)DefibliratorFields.LATITUDE]);

        //        return isParsingSuccusful;
        //    }

        //    public bool ParseLongitude(string text)
        //    {
        //        bool isParsingSuccusful = double.TryParse(text, out longitude);
        //        return isParsingSuccusful;
        //    }

        //    public bool ParseLatitude(string text)
        //    {
        //        bool isParsingSuccusful = double.TryParse(text, out latitude);
        //        return isParsingSuccusful;
        //    }

        //    public double longitude;
        //    public double latitude;
        //};

        //private struct DefibliratorInfo
        //{
        //    public bool Parse(string[] data)
        //    {

        //        organization = data[(int)DefibliratorFields.ORGANIZATION];
        //        address = data[(int)DefibliratorFields.ADDRESS];

        //        bool isParsingSuccusful = false;
        //        isParsingSuccusful = position.Parse(data);

        //        return isParsingSuccusful;
        //    }
        //    public override string ToString() 
        //    {
        //        return $"Name: {organization}; Address: {address}";
        //    }


        //    public string organization;
        //    public string address;

        //    public Position position;
        //}

        //private static double Distance(in Position userPos, in Position defibliratorPos)
        //{
        //    const int RAD_COEFICIENT = 6371;
        //    double x = (defibliratorPos.longitude - userPos.longitude)
        //        * Math.Cos((userPos.latitude + defibliratorPos.latitude) / 2.0);
        //    double y = (defibliratorPos.latitude - userPos.latitude);

        //    return Math.Sqrt(x * x + y * y) * RAD_COEFICIENT;
        //}

        static void Main(string[] args)
        {
            Func<Task3, string> TaskSolver = task =>
            {
                //int placesAmount = task.DefibliratorStorages.Length;

                //Position userPosition = default;

                //if (!userPosition.ParseLongitude(task.UserLongitude) || !userPosition.ParseLatitude(task.UserLatitude))
                //{
                //    Console.WriteLine("Bad user data");
                //    //throw (new Exception("Parsing error - bad user data"));
                //}

                ////  <distance, formated string>
                //DefibliratorInfo defiblirator = default;
                //string result = default;
                //double minDistance = double.MaxValue;
                //double distance = default;

                //for (int i = 0; i < placesAmount; i++)
                //{
                //    string defibliratorStorage = task.DefibliratorStorages[i];
                //    string[] splitedDefibliratorStorage = defibliratorStorage.Split(';');

                //    bool isParsingSuccusful = defiblirator.Parse(splitedDefibliratorStorage);
                //    if (isParsingSuccusful)
                //    {
                //        distance = Distance(in userPosition, in defiblirator.position);
                //        if(minDistance > distance)
                //        {
                //            minDistance = distance;
                //            result = defiblirator.ToString();
                //        }
                //    }
                //}

                //return result;
                return "bla";
            };

            Task3.CheckSolver(TaskSolver);
        }
    }
}

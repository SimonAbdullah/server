﻿using MediatR;
using Sygic.Corona.Contracts.Responses;

namespace Sygic.Corona.Application.Commands
{
    public class CreateProfileCommand : IRequest<CreateProfileResponse>
    {
        public string DeviceId { get; }
        public string PushToken { get; }
        public string PhoneNumber { get; }
        public string Locale { get; }
        public double? Latitude { get; }
        public double? Longitude { get; }
        public double? Accuracy { get; }

        public CreateProfileCommand(string deviceId, string pushToken, string phoneNumber, string locale, double? latitude, double? longitude, double? accuracy)
        {
            DeviceId = deviceId;
            PushToken = pushToken;
            PhoneNumber = phoneNumber;
            Locale = locale;
            Latitude = latitude;
            Longitude = longitude;
            Accuracy = accuracy;
        }
    }
}

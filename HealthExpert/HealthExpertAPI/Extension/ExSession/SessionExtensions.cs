using BussinessObject.Model.ModelSession;
using HealthExpertAPI.DTO.DTOSession;

namespace HealthExpertAPI.Extension.ExSession
{
    public static class SessionExtensions
    {
        public static SessionDTO ToSessionDTO(this Session session)
        {
            return new SessionDTO
            {
                sessionId = session.sessionId,
                sessionName = session.sessionName,
                dateStart = session.dateStart,
                dateEnd = session.dateEnd,
                description = session.description,
                learnProgress = session.learnProgress
            };
        }

        public static Session ToSessionAdd(this SessionDTO sessionDTO)
        {
            return new Session
            {
                sessionId = sessionDTO.sessionId,
                sessionName = sessionDTO.sessionName,
                dateStart = sessionDTO.dateStart,
                dateEnd = sessionDTO.dateEnd,
                description = sessionDTO.description,
                learnProgress = sessionDTO.learnProgress,
            };
        }

        public static Session ToSessionUpdate(this SessionUpdateDTO sessionDTO)
        {
            return new Session
            {
                //sessionId = sessionDTO.sessionId,
                sessionName = sessionDTO.sessionName,
                dateStart = sessionDTO.dateStart,
                dateEnd = sessionDTO.dateEnd,
                description = sessionDTO.description
            };
        }
    }
}

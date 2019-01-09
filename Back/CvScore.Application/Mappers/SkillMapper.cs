using System.Collections.Generic;
using AutoMapper;
using CV.Application.DTO;
using CV.Model.Skills;

namespace CV.Application.Mappers
{
    public static class SkillMapper
    {

        /// <summary>
        /// convert to skill 
        /// </summary>
        /// <param name="skill"></param>
        /// <returns></returns>
        public static SkillDTO ConvertToSkillDTO(this Skill skill)
        {
            return Mapper.Map<Skill, SkillDTO>(skill);
        }


        /// <summary>
        /// Convert to Skill Model 
        /// </summary>
        /// <param name="skillDTO"></param>
        /// <returns></returns>
        public static Skill ConvertToSkillModel(this SkillDTO skillDTO)
        {
            return Mapper.Map<SkillDTO, Skill>(skillDTO);
        }


        /// <summary>
        /// Concert to Skill DTO List
        /// </summary>
        /// <param name="skill"></param>
        /// <returns></returns>
        public static IEnumerable<SkillDTO> ConvertToSkillDTOList(this IEnumerable<Skill> skill)
        {
            return Mapper.Map<IEnumerable<Skill>, IEnumerable<SkillDTO>>(skill);
        }

    }
}

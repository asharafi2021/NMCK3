﻿using NMCK3.Domain.Primitives;
using System;

namespace NMCK3.Domain.Entities
{
    public sealed class ExamReservation : Entity
    {
        internal ExamReservation(Guid id, User participant, Exam exam)
            : base(id)
        {
            Participant = participant;
            Exam = exam;
        }


        public double ReadingScore { get; private set; } = 0.0;

        public double ListeningScore { get; private set; } = 0.0;

        public double SpeakingScore { get; private set; } = 0.0;

        public double WritingScore { get; private set; } = 0.0;

        public string ScoreSubmitDate { get; private set; }

        public User Participant { get; private set; }

        public Exam Exam { get; private set; }
    }
}

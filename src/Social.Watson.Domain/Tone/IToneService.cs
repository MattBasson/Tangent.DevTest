﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Social.Watson.Domain.Tone
{
    public interface IToneService
    {
        ToneResponse Analyze(ToneSubmission submission);
    }
}

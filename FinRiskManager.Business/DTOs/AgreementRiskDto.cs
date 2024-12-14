using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinRiskManager.Business.DTOs;

public class AgreementRiskDto
{
    public string AgreementName { get; set; }
    public string AgreementDate { get; set; }
    public string TopicName { get; set; }
    public decimal RiskAmount { get; set; }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommvaultWebsiteSeleniumTest
{
    public class PageList
    {
        string[] _elements =
{
    "/case-studies",
    "/case-studies/beth-israel-deaconess-medical-center",
    "/case-studies/onx",
    "/case-studies/rackspace",
    "/case-studies/ubistor",
    "/contact-us",
    "/contact-us/email",
    "/contact-us/india",
    "/demos-and-trials",
    "/demos-and-trials/vm-backup-and-recovery",
    "/demos-and-trials/endpoint-protection",
    "/how-to-buy",
    "/how-to-buy/popular-bundles/vm-backup-and-recovery",
    "/how-to-buy/popular-bundles/cloud-backup-and-recovery",
    "/how-to-buy/popular-bundles/email-archive",
    "/how-to-buy/popular-bundles/endpoint-data-protection",
    "/how-to-buy/popular-bundles/snapshot-management-and-recovery",
    "/how-to-buy/popular-bundles/appliances",
    "/services",
    "/services/business-consulting/data-classification-and-archive-policy-design",
    "/services/business-consulting/disaster-recovery-readiness-and-policy-design",
    "/services/business-consulting/operational-efficiency-assessment",
    "/services/business-consulting/private-cloud-services-design",
    "/services/technology-consulting/architecture-design",
    "/services/technology-consulting/data-migration",
    "/services/technology-consulting/health-assessment",
    "/services/technology-consulting/implementation",
    "/services/technology-consulting/personalization",
    "/services/technology-consulting/residency-services",
    "/services/remote-managed-services",
    "/solutions",
    "/solutions/by-function",
    "/solutions/by-function/cloud-and-infrastructure-management/cloud-management/cloud-operations-and-management",
    "/solutions/by-function/cloud-and-infrastructure-management/snapshot-management",
    "/solutions/by-function/cloud-and-infrastructure-management/snapshot-management/intellisnap",
    "/solutions/by-function/cloud-and-infrastructure-management/snapshot-management/intellisnap/hds",
    "/solutions/by-function/cloud-and-infrastructure-management/snapshot-management/intellisnap/netapp",
    "/solutions/by-function/cloud-and-infrastructure-management/workflow-and-automation",
    "/solutions/by-function/data-protection-backup-and-recovery/appliance",
    "/solutions/by-function/data-protection-backup-and-recovery/appliance/fujitsu",
    "/solutions/by-function/data-protection-backup-and-recovery/appliance/netapp",
    "/solutions/by-function/data-protection-backup-and-recovery/databases",
    "/solutions/by-function/data-protection-backup-and-recovery/databases/oracle",
    "/solutions/by-function/data-protection-backup-and-recovery/databases/sql",
    "/solutions/by-function/data-protection-backup-and-recovery/endpoints",
    "/solutions/by-function/data-protection-backup-and-recovery/endpoints/endpoint-data-protection",
    "/solutions/by-function/data-protection-backup-and-recovery/enterprise-applications",
    "/solutions/by-function/data-protection-backup-and-recovery/enterprise-applications/microsoft-exchange",
    "/solutions/by-function/data-protection-backup-and-recovery/enterprise-applications/microsoft-sharepoint",
    "/solutions/by-function/data-protection-backup-and-recovery/enterprise-applications/sap",
    "/solutions/by-function/data-protection-backup-and-recovery/files",
    "/solutions/by-function/data-protection-backup-and-recovery/files/self-service-file-recovery",
    "/solutions/by-function/data-protection-backup-and-recovery/files/snapshot-management-and-recovery",
    "/solutions/by-function/data-protection-backup-and-recovery/source-side-software-deduplication",
    "/solutions/by-function/data-protection-backup-and-recovery/vm-and-cloud",
    "/solutions/by-function/data-protection-backup-and-recovery/vm-and-cloud/cloud-connected-backup",
    "/solutions/by-function/data-protection-backup-and-recovery/vm-and-cloud/cloud-disaster-recovery",
    "/solutions/by-function/data-protection-backup-and-recovery/vm-and-cloud/cloud-disaster-recovery/amazon-aws",
    "/solutions/by-function/data-protection-backup-and-recovery/vm-and-cloud/cloud-disaster-recovery/microsoft-azure",
    "/solutions/by-function/data-protection-backup-and-recovery/vm-and-cloud/cloud-disaster-recovery/private-or-hybrid-cloud",
    "/solutions/by-function/data-protection-backup-and-recovery/vm-and-cloud/hyper-v",
    "/solutions/by-function/data-protection-backup-and-recovery/vm-and-cloud/instant-recovery",
    "/solutions/by-function/data-protection-backup-and-recovery/vm-and-cloud/vmware",
    "/solutions/by-function/retention-and-compliance/content-based-retention",
    "/solutions/by-function/retention-and-compliance/data-loss-prevention",
    "/solutions/by-function/retention-and-compliance/email-archiving",
    "/solutions/by-function/retention-and-compliance/enterprise-search-and-ediscovery",
    "/solutions/by-function/retention-and-compliance/secure-file-sharing",
    "/solutions/by-industry",
    "/solutions/by-industry/education",
    "/solutions/by-industry/government",
    "/solutions/by-industry/government/corporate-information",
    "/solutions/by-industry/healthcare",
    "/solutions/by-industry/healthcare/clinical-archiving",
    "/solutions/by-industry/legal",
    "/solutions/by-industry/service-providers",
    "/solutions/by-technology",
    "/solutions/by-technology/converged-infrastructure/cisco-ucs",
    "/solutions/by-technology/converged-infrastructure/hitachi-data-systems",
    "/solutions/by-technology/converged-infrastructure/nutanix",
    "/solutions/by-technology/databases/microsoft-sql-server",
    "/solutions/by-technology/databases/mongodb",
    "/solutions/by-technology/databases/oracle",
    "/solutions/by-technology/enterprise-applications",
    "/solutions/by-technology/enterprise-applications/microsoft-active-directory",
    "/solutions/by-technology/enterprise-applications/microsoft-exchange",
    "/solutions/by-technology/enterprise-applications/microsoft-sharepoint",
    "/solutions/by-technology/virtual-machine-and-cloud/amazon-web-services",
    "/solutions/by-technology/virtual-machine-and-cloud/citrix-xen-server",
    "/solutions/by-technology/virtual-machine-and-cloud/hyper-v",
    "/solutions/by-technology/virtual-machine-and-cloud/microsoft-azure",
    "/solutions/by-technology/virtual-machine-and-cloud/vmware",
    "/solutions/by-topic",
    "/solutions/by-topic/comprehensive-information-governance",
    "/solutions/by-topic/comprehensive-information-governance/geolocation-restrictions-and-data-sovereignty",
    "/solutions/by-topic/comprehensive-information-governance/governance-of-information",
    "/solutions/by-topic/control-enterprise-mobility/endpoint-data-protection",
    "/solutions/by-topic/control-enterprise-mobility/information-archiving-and-compliance",
    "/solutions/by-topic/control-enterprise-mobility/managing-risk-with-bring-your-own-device",
    "/solutions/by-topic/control-enterprise-mobility/secure-file-sharing-for-the-enterprise",
    "/solutions/by-topic/gain-efficiency/bill-backs-and-metering",
    "/solutions/by-topic/gain-efficiency/self-service-and-consumerization-of-it",
    "/solutions/by-topic/gain-efficiency/workflow-automation-and-convergence",
    "/solutions/by-topic/transition-to-the-cloud",
    "/solutions/by-topic/transition-to-the-cloud/public-private-or-hybrid-cloud",
    "/solutions/by-topic/using-a-data-management-platform",
    "/support",
    "/partners",
    "/partners/find-a-partner",
    "/partners/find-a-partner/find-a-reseller",
    "/partners/find-a-partner/global-oem",
    "/partners/find-a-partner/global-oem/hitachi-data-systems",
    "/partners/find-a-partner/global-oem/netapp",
    "/partners/find-a-partner/technology-alliance",
    "/partners/find-a-partner/technology-alliance/amazon-web-services",
    "/partners/find-a-partner/technology-alliance/microsoft",
    "/partners/find-a-partner/intellisnap-connect",
    "/partners/find-a-partner/service-providers",
    "/partners/become-a-partner",
    "/partners/become-a-partner/resellers",
    "/partners/become-a-partner/technology-alliance",
    "/partners/become-a-partner/service-providers",
    "/partners/find-a-partner/service-providers"
}
;

        /// <summary>
        /// String array property getter.
        /// </summary>
        public string[] Elements
        {
            get { return _elements; }
        }

        /// <summary>
        /// String array indexer.
        /// </summary>
        public string this[int index]
        {
            get { return _elements[index]; }
        }
    }
}

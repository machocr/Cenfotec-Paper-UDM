using System;
namespace UDMNoSQL.Api.Models
{
    public enum RoleType
    {
        Prospect,
        Shareholder,
        //Person Roles
        Employee,
        Contractor,
        FamilyMember,
        Contact,
        //Organization
        InternalOrganization,
        Partner,
        Household,
        Supplier,
        Competitor,
        RegulatoryAgency,
        Assciation,
        //Distribution Channel
        Agent,
        Distribuitor,
        //Organization Unit
        ParentOrganization,
        Subsidiary,
        Department,
        Division,
        OtherOrganizationUnit,
        //Customer
        BillToCustomer,
        ShipToCustomer,
        EndUserCustomer,
    }
}


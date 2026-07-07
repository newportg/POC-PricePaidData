---
title: 04-Deployment
date: 2026-07-06
status: Draft
---

## Goal
[What are we trying to achieve?]

```plantuml 
@startuml
!include <C4/C4_Component>

'LAYOUT_WITH_LEGEND()
LAYOUT_LEFT_RIGHT()

System_Boundary(c1, "System") {
    Container_Boundary(client, "Client") {
        System(web, "Web Gui") 
    }

    Container_Boundary(server, "Server") {
	    Container_Boundary(domain, "API / Business Logic") {
	        System(api, "RestAPI") 
	        System(bll, "Business Logic / Rules") 
	        
	        api -[hidden]-> bll
	    }
	    
	    Container_Boundary(svc, "Services") {
			Container(db_svc, "Postgres interface service")
		    Container(ppd_svc, "Price Paid Data service")
			
			db_svc -[hidden]> ppd_svc
	    }

		SystemDb(ql, "Hasura", "GraphQL", $tags = "storage")
	    SystemDb(pdb, "Postgres DB", "Transaction Managemnt Storage", $tags = "storage")
	    ql -down-> pdb
    }
    
}
System_Ext(ppd, "Land Registry Price Paid Data Service") 


client -[hidden]-> domain
domain -[hidden]-> svc

'web -> api
'api -> bll : write
'api -> ql : read
'bll --> ppd_svc
'bll --> db_svc
'ppd_svc --> ppd
'db_svc -> pdb

Rel(web, api, "")
Rel(api, bll, "write")
Rel(api, ql, "read")
Rel(bll, ppd_svc, "")
Rel(bll, db_svc, "")
Rel(ppd_svc, ppd, "")
Rel(db_svc, pdb, "")

@enduml
```

1. Postgres DB server will be in a container
2. Hasura GraphQL server will be in a container
3. The Client, Business Logic and Services will be in a container.
4. API will be a Azure Function with a OpenAPI interface.
5. There will be a deployment script written in Bicep
6. The application will be built for Azure.
7. The applications will be able to be run locally.



## Acceptance Criteria
- [ ] Criterion 1
- [ ] Criterion 2

## Out of Scope
[What this spec deliberately does not cover]

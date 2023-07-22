/*
{
  "acronym": "dnsop",
  "ad": null,
  "charter": "/api/v1/doc/document/charter-ietf-dnsop/",
  "comments": "1st meeting at 44th IETF-Minneapolis, MN\r\n\r\nAD was Harald",
  "description": "The DNS Operations Working Group will develop guidelines for the\noperation of DNS software and services and for the administration\nof DNS zones.  These guidelines will provide technical information\nrelating to the implementation of the DNS protocol by the operators\nand administrators of DNS zones. The group will perform the following\nactivities:",
  "id": 1452,
  "list_archive": "https://mailarchive.ietf.org/arch/browse/dnsop/",
  "list_email": "dnsop@ietf.org",
  "list_subscribe": "http://www.ietf.org/mailman/listinfo/dnsop",
  "meeting_seen_as_area": false,
  "name": "Domain Name System Operations",
  "parent": "/api/v1/group/group/1193/",
  "resource_uri": "/api/v1/group/group/1452/",
  "state": "/api/v1/name/groupstatename/active/",
  "time": "2023-04-16T19:45:59Z",
  "type": "/api/v1/name/grouptypename/wg/",
  "unused_states": [],
  "unused_tags": [],
  "used_roles": "[]",
  "uses_milestone_dates": true
}
*/

model group {
    acronym: string;
    ad: string;
    charter: string;
    comments: string;
    description: string;
    id: int64;
    list_archive: string;
    list_email: string;
    list_subscribe: string;
    meeting_seen_as_area: boolean;
    name: string;
    parent: string;
    resource_uri: string;
    state: string;
    time: string;
    type: string;
    unused_states: string[];
    unused_tags: string[];
    used_roles: string[];
    uses_milestone_dates: boolean;
}

model groupEvent {
    desc: string;
    group: string;
    id: int64;
    resource_uri: string;
    time: string;
    title: string;
}

model groupHistory {
    comment: string;
    group: string;
    id: int64;
    resource_uri: string;
    time: string;
}

model groupMilestone {
    desc: string;
    due: string;
    group: string;
    id: int64;
    resolved: string;
    resource_uri: string;
    state: string;
    time: string;
    title: string;
}

model groupRole {
    email: string;
    group: string;
    id: int64;
    name: string;
    person: string;
    resource_uri: string;
}

model groupState {
    desc: string;
    id: int64;
    name: string;
    order: int64;
    resource_uri: string;
    slug: string;
}



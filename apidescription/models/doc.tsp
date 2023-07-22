/*
{
      "abstract": "",
      "ad": null,
      "expires": null,
      "external_url": "",
      "group": "/api/v1/group/group/1581/",
      "id": 6013,
      "intended_std_level": null,
      "internal_comments": "",
      "name": "agenda-71-lemonade",
      "note": "",
      "notify": "",
      "pages": null,
      "resource_uri": "/api/v1/doc/document/agenda-71-lemonade/",
      "rev": "00",
      "rfc": null,
      "shepherd": null,
      "states": [
        "/api/v1/doc/state/81/"
      ],
      "std_level": null,
      "stream": null,
      "submissions": [],
      "tags": [],
      "time": "2008-03-09T02:23:43Z",
      "title": "Agenda for LEMONADE at IETF-71",
      "type": "/api/v1/name/doctypename/agenda/",
      "uploaded_filename": "lemonade.txt",
      "words": null
    }
*/

model document {
    abstract: string;
    ad: string;
    expires: string;
    external_url: string;
    group: string;
    id: int64;
    intended_std_level: string;
    internal_comments: string;
    name: string;
    note: string;
    notify: string;
    pages: string;
    resource_uri: string;
    rev: string;
    rfc: string;
    shepherd: string;
    states: string[];
    std_level: string;
    stream: string;
    submissions: string[];
    tags: string[];
    time: string;
    title: string;
    type: string;
    uploaded_filename: string;
    words: string;
}

model docAlias {
    document: string;
    id: int64;
    name: string;
    resource_uri: string;
}

model docEvent {
    by: string;
    desc: string;
    doc: string;
    id: int64;
    resource_uri: string;
    rev: string;
    time: string;
}

model docRelationship {
    id: int64;
    relationship: string;
    resource_uri: string;
    source: string;
    target: string;
}

model docReminder {
    active: boolean;
    due: string;
    event: string;
    id: int64;
    offset_days: int64;
    resource_uri: string;
}

model docTagName {
    id: int64;
    name: string;
    resource_uri: string;
}

model docType {
    id: int64;
    name: string;
    resource_uri: string;
}

model docTypeName {
    id: int64;
    name: string;
    resource_uri: string;
}

model stateDocEvent {
    by: string;
    desc: string;
    doc: string;
    docevent_ptr: string;
    id: int64;
    resource_uri: string;
    rev: string;
    state: string;
    state_type: string;
    time: string;
    type: string;
}

model state {
  id: int32;
  name: string;
  slug: string;
  desc: string;
  order: string;
  type_id: string;
  used: boolean;
  resource_uri: string;
}
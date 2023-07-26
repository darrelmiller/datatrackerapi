import "@typespec/http";

import "./models/doc.tsp";
import "./models/group.tsp";

using TypeSpec.Http;

@service({
    title: "IETF Datatracker",
    description: "Datatracker API",
    version: "1.0.0"
  })
@server("https://datatracker.ietf.org","default")
@route("/api")
namespace api {
    @route("version")
    op get(): version;

    @route("openid")
    @post op submitAuthRequest(): string;

    @route("iesg/position")
    op postIesgBallotPosition(@body form: iesgBallotPositionForm): string;

    // @route("export/personal-information")
    // op exportPersonalInformation(): string;

    @route("submit")
    op submitDraft(): string;

    @route("submission")
    @post op uploadSubmission(): string;

    @route("submission/{identifier}/status")
    op getSubmissionStatus(identifier:string): string;

    @route("meeting")
    namespace meeting {
        @route("session/video/url")
        @post 
        op postSessionVideoUrl(@body form: sessionVideoForm): string;
        
        @route("{identifier}/agenda-data")
        op getAgendaData(identifier: string): string;

        @route("{identifier}/session/{session}/materials")
        op getSessionMaterials(identifier: string, session: string): string;     
    }

    @route("notify")
    namespace notifySection {
        @route("meeting/bluesheets")
        @post op uploadBluesheets(): string;

        @route("meeting/registration")
        @post op uploadMeetingRegistration(): string;

        @route("session/attendees")
        @post op uploadSessionAttendees(): string;

        @route("session/chatlog")
        @post op uploadSessionChatlog(): string;

        @route("session/polls")
        @post op uploadSessionPolls(): string;
    }

    @route("/v1")
    namespace v1 
    {
        @route("doc")
        namespace docSection {
            @route("document")
            interface docResources extends TPModel<document> {}
    
            @route("state")
            interface stateResources extends TPModel<state> {}
            
            @route("docevent")
            interface docEvents extends TPModel<docEvent> {}

            @route("docalias")
            interface docAliases extends TPModel<docAlias> {}

            @route("statedocevent")
            interface stateDocEvents extends TPModel<stateDocEvent> {}

            @route("dochistory")
            interface docHistoryResources  {
                op getlist( @query limit?: int32, 
                            @query offset?: int32,
                            @query doc:int64 ): listResource<docHistory>;
            
            }
        }

        @route("group")
        namespace groupSection {
            @route("group")
            interface groupResources extends TPModel<group> {}

            @route("events")
            interface groupEvents extends TPModel<groupEvent> {}

            @route("milestones")
            interface groupMilestones extends TPModel<groupMilestone> {}

        }
    }

    @route("/v2")
    namespace v2 {
        @route("person/person")
        op exportPerson(): string;
    }
}

interface TPModel<T> {
    op getlist(@query limit?: int32, @query offset?: int32): listResource<T>;

    @route("{identifier}")
    op getitem(identifier: string): T;
}

model listResource<T> {
    meta: meta;
    objects: T[];   
}

model version {
    version: string;
    dump: string;
}

model meta {
    limit: int32;
    next: string;
    offset: int32;
    previous: string;
    total_count: int32;
}

model sessionVideoForm {
    @header contentType: "application/x-www-form-urlencoded";
    @doc("(required) which is the personal API key hash")
    apikey: string; 
    @doc("(required) which is the meeting number")  
    meeting: string;
    @doc("(required) which is the group acronym")
    group: string;
    @doc("(required) which is the chronological sequence number of the session (1 for a group's first session, 2 for the second, etc.)")
    item: string;
    @doc("(required) which is the url that points to the video recording") 
    url: string;
}

model iesgBallotPositionForm {
    @header contentType: "application/x-www-form-urlencoded";
    @doc("(required) which is the personal API key hash")
    apikey: string;
    @doc("(required) which is the balloted document name")
    doc:string; 
    @doc("(required) which is the position slug, one of: yes, noobj, block, discuss, abstain, recuse, norecord .")
    position:string; 
    @doc("(required if position is discuss) which is the discuss text")
    discuss:string;  
    @doc("(optional) which is the comment text")
    comment:string;
}
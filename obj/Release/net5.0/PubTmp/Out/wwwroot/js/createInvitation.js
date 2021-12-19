document.addEventListener('DOMContentLoaded', function (ev) {
    var createbtn = document.getElementById("CreateBtn")
    var addNoteBtn = document.getElementById("AddNote")
    //var noteCbx = document.getElementById("Note")

    var noteID = -1
    var scheduleID = -1

    addNoteBtn.addEventListener('click', function () {
        const notes = document.querySelectorAll('.note')
        //console.log(notes)
        //console.log(notes.length)

        var noteValues = []
        for (let i = 0; i < notes.length; i++) {
            noteValues[i] = notes[i].value
        }

        var content = ""
        for (let i = 0; i < notes.length; i++) {
            content += '<li><input type="text" value="' + noteValues[i] + '" class="note" placeholder="Note" /></li>'
            //console.log(content)
        }
        content += '<li><input type="text" value="" class="note" placeholder="Note" /></li>'
        document.getElementById('NotesOnly').innerHTML = content
    })

    createbtn.addEventListener("click", async function (e) {
        e.preventDefault();
        //console.log("Hello World!")
        //console.log(document.getElementById("OwnerEmail").value)

        var noteCbx = document.getElementById("Note")
        var scheduleCbx = document.getElementById("ScheduleId")

        var nId = -1
        var sId = -1

        if (noteCbx.checked == true) {
            const notes = document.querySelectorAll('.note')
            var noteData = ""
            for (let i = 0; i < notes.length; i++) {
                if (!isEmpty(notes[i].value)) {
                    noteData = noteData + '{"NoteValue": "' + notes[i].value + '"},'
                }
            }
            noteData = noteData.substring(0, noteData.length - 1);

            if (!isEmpty(noteData)) {
                nId = 0
                HandleNotes(noteData)
            }
        }

        if (scheduleCbx.checked == true) {
            const schedIs = document.querySelectorAll('.sched')
            var schedData = ""
            for (let i = 0; i < schedIs.length; i++) {
                if (!isEmpty(schedIs[i].value)) {
                    schedData = schedData + '{"ItemName": "' + schedIs[i].value + '"},'
                }
            }
            schedData = schedData.substring(0, schedData.length - 1);

            if (!isEmpty(schedData)) {
                sId = 0
                HandleSchedules(schedData)
            }
        }
        
        var noteContainer = document.getElementById("NotesContainer")
        var scheduleContainer = document.getElementById("ScheduleContainer")

        setTimeout(function () {
            var OwnerEmail = document.getElementById("OwnerEmail").value
            var InvitationIntro = document.getElementById("InvitationIntro").value
            var OurStory = document.getElementById("OurStory").value
            var Venue = document.getElementById("Venue").value
            var VenueLocation = document.getElementById("VenueLocation").value
            var VenueWebsite = document.getElementById("VenueWebsite").value
            var WeddingName = document.getElementById("WeddingName").value
            var WeddingDate = document.getElementById("WeddingDate").value
            var RSVPDate = document.getElementById("RSVPDate").value

            var formData = {
                "OwnerEmail": OwnerEmail, "InvitationIntro": InvitationIntro,
                "OurStory": OurStory, "Venue": Venue,
                "VenueLocation": VenueLocation, "VenueWebsite": VenueWebsite,
                "WeddingDate": WeddingDate, "RSVPDate": RSVPDate, "WeddingName": WeddingName,
                "ScheduleId": sId, "NotesId": nId
            }; // JSON.stringify(arrValues);
            console.log(JSON.stringify(formData))
            $.ajax({
                type: "POST",
                url: (window.location.origin + "/User/Invitations/CreateJson"), //this.action
                data: JSON.stringify(formData),
                dataType: "Invite",
                success: function (data) {
                    if (data.success) {
                        console.log("success")
                        toastr.success(data.message);
                        window.location.href = (window.location.origin + "/User/Invitations/ViewSingle?UserName=" + document.getElementById("OwnerEmail").value)
                    }
                    else {
                        console.log("fail")
                        toastr.error(data.message);
                    }
                },
                dataType: "json",
                contentType: "application/json"
            });
        }, 1000);

        console.log("done")
    })
}, false);

async function HandleNotes(notes) {
    console.log("handlenotes")
    var formData = '[' + notes + ']'
    console.log(formData)
    console.log(window.location.origin + "/User/Invitations/NotesJson")
    $.ajax({
        type: "POST",
        url: (window.location.origin + "/User/Invitations/NotesJson"),
        data: formData,
        success: async function (data) {
            if (data.success) {
                console.log("success")
                return data.message
            }
            else {
                console.log("fail")
                return data.message
            }
        },
        dataType: "json",
        contentType: "application/json"
    });
}

async function HandleSchedules(sched) {
    var formData = '[' + sched + ']'
    console.log(formData)
    $.ajax({
        type: "POST",
        url: (window.location.origin + "/User/Invitations/SchedulesJson"),
        data: formData,
        success: async function (data) {
            if (data.success) {
                console.log("success")
                return data.message
            }
            else {
                console.log("fail")
                return data.message
            }
        },
        dataType: "json",
        contentType: "application/json"
    });
}

function AddNote() {
    console.log("Note added")
    var content = document.getElementById('NotesOnly').innerHTML
    content += '<li><input type="text" value="" class="note" placeholder="Note" /></li>'
    document.getElementById('NotesOnly').innerHTML = content
}

async function HandleNote(note) {
    var ID = -1
    if (!isEmpty(note)) {
        console.log("handlenote")
        var formData = {
            "NoteValue": note
        };
        console.log(formData)
        $.ajax({
            type: "POST",
            url: (window.location.origin + "/User/Invitations/NoteJson"),
            data: JSON.stringify(formData),
            dataType: "NoteItem",
            success: async function (data) {
                if (data.success) {
                    console.log("success")
                    console.log(data.message)
                    ID = await data.message;
                }
                else {
                    console.log("fail")
                    ID = await data.message;
                }
            },
            dataType: "json",
            contentType: "application/json"
        });
    }

    return ID
}

function HandleNoteOnly(note, noteId) {
    if (!isEmpty(note)) {
        console.log("handlenoteOnly")
        var formData = {
            "NoteValue": note
        };
        console.log("ID: " + noteId)
        $.ajax({
            type: "POST",
            url: (window.location.origin + "/User/Invitations/NoteJson/" + noteId),
            data: JSON.stringify(formData),
            dataType: "NoteItem",
            success: function (data) {
                if (data.success) {
                    console.log("success")
                    //return data.message;
                }
                else {
                    console.log("fail")
                    //return data.message;
                }
            },
            dataType: "json",
            contentType: "application/json"
        });
    }
}

function HandleSched(sc) {
    //if (!is_empty(note.toString().trim())) {
    if (!isEmpty(sc.value.toString().trim())) {
        console.log(sc.value)
    }
}

function empty(e) {
    switch (e) {
        case "":
        case " ":
        case 0:
        case "0":
        case null:
        case false:
        case typeof (e) == "undefined":
            return true;
        default:
            return false;
    }
}

function is_empty(x) {
    return (                                                           //don't put newline after return
        (typeof x == 'undefined')
        ||
        (x == null)
        ||
        (x == false)        //same as: !x
        ||
        (x.length == 0)
        ||
        (x.length.toString() == 'undefined')
        ||
        (x == 0)            // note this line, you might not need this. 
        ||
        (x == "")
        ||
        (x.replace(/\s/g, "") == "")
        ||
        (!/[^\s]/.test(x))
        ||
        (/^\s*$/.test(x))
        ||
        empty(x)
    );
}

function isEmpty (data) {
    if (typeof (data) === 'object') {
        if (JSON.stringify(data) == '{}' || JSON.stringify(data) == '[]') {
            return true;
        } else if (!data) {
            return true;
        }
        return false;
    } else if (typeof (data) === 'string') {
        return is_empty(data);
    } else if (typeof (data) === 'undefined') {
        return true;
    } else {
        return false;
    }
}
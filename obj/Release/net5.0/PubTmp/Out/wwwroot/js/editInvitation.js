document.addEventListener('DOMContentLoaded', function (ev) {
    var addNoteBtn = document.getElementById("AddNote")
    var updateBtn = document.getElementById("EditBtn")

    updateWeddingDate()
    updateRSVPDate()
    getNotes();

    updateBtn.addEventListener('click', function (e) {
        e.preventDefault();

        var noteCbx = document.getElementById("Note")

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
                "NotesId": nId
            }; // JSON.stringify(arrValues);
            console.log(JSON.stringify(formData))
            console.log(formData)
            console.log(window.location.origin + "/User/Invitations/UpdateInvitation")
            $.ajax({
                type: "POST",
                url: (window.location.origin + "/User/Invitations/UpdateInvitation" ), //this.action
                data: JSON.stringify(formData),
                dataType: "Invite",
                success: function (data) {
                    if (data.success) {
                        console.log("success")
                        toastr.success("Update Successful");
                        window.location.href = (window.location.origin + "/User/Invitations/ViewInvitation/" + document.getElementById("invId").innerText)
                    }
                    else {
                        console.log("fail")
                        toastr.error(data.message);
                        console.log(data.message)
                    }
                },
                dataType: "json",
                contentType: "application/json"
            });
        }, 1000);

        console.log("done")
    })

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
})

function getNotes() {
    var id = document.getElementById('invId').innerText
    $.ajax({
        type: "GET",
        url: (window.location.origin + "/User/Invitations/GetNoteList/" + id),
        success: function (data) {
            if (data.success) {
                //console.log(data.message)
                var noteValues = data.message.split('#%#')

                var content = ""
                for (let i = 0; i < noteValues.length; i++) {
                    content += '<li><input type="text" value="' + noteValues[i] + '" class="note" placeholder="Note" /></li>'
                    //console.log(content)
                }
                content += '<li><input type="text" value="" class="note" placeholder="Note" /></li>'
                document.getElementById('NotesOnly').innerHTML = content
                document.getElementById('Note').checked = true
                document.getElementById('NotesContainer').classList.toggle('hidden')
            } else {
                console.log(data.message)
            }
        },
        dataType: "json"
    });
}

function updateWeddingDate() {
    /*
    var dateStr = document.getElementById('weddingDate').innerText.substring(0, 10).trim()
    var d
    var m
    var y

    var idx = dateStr.indexOf('/')
    m = dateStr.substring(0, idx)
    dateStr = dateStr.substring(idx + 1)
    idx = dateStr.indexOf('/')
    d = dateStr.substring(0, idx)
    dateStr = dateStr.substring(idx + 1)
    y = dateStr

    console.log(y + '-' + m + '-' + d)
    */
    var date = new Date(document.getElementById('weddingDate').innerText.substring(0, 10).trim())
    var month = (date.getMonth() + 1);
    var day = date.getDate();
    if (month < 10)
        month = "0" + month;
    if (day < 10)
        day = "0" + day;
    var finalDate = date.getFullYear() + '-' + month + '-' + day;
    /*
    console.log(finalDate)
    console.log(date.toISOString().substring(0, 10))
    */
    document.getElementById('WeddingDate').value = finalDate
}

function updateRSVPDate() {
    var date = new Date(document.getElementById('rsvpDate').innerText.substring(0, 10).trim())
    var month = (date.getMonth() + 1);
    var day = date.getDate();
    if (month < 10)
        month = "0" + month;
    if (day < 10)
        day = "0" + day;
    var finalDate = date.getFullYear() + '-' + month + '-' + day;

    document.getElementById('RSVPDate').value = finalDate
}

function HandleNotes(notes) {
    var id = document.getElementById('invId').innerText
    var formData = id + ', [' + notes + ']'
    console.log(formData)
    console.log(window.location.origin + "/User/Invitations/UpdateNotesJson")
    $.ajax({
        type: "POST",
        url: (window.location.origin + "/User/Invitations/UpdateNotesJson"),
        data: formData,
        success: function (data) {
            if (data.success) {
                console.log("success")
            }
            else {
                console.log("fail")
                console.log(data.message)
            }
        },
        dataType: "json",
        contentType: "application/json"
    });
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

function isEmpty(data) {
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
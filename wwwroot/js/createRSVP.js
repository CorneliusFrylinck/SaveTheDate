document.addEventListener('DOMContentLoaded', function (ev) {
    var createbtn = document.getElementById("CreateBtn")
    var DeclineBtn = document.getElementById("DeclineBtn")
    var guestListId = document.querySelector(".guestId").innerText

    var backBtn = document.querySelector('.backToInv');

    backBtn.addEventListener('click', function () {
        $.ajax({
            type: "GET",
            url: (window.location.origin + "/User/Invitations/GetGuestInvitation/" + guestListId),
            success: function (data) {
                if (data.success) {
                    window.location.href = (window.location.origin + "/User/Invitations/ViewInvitation/" + data.message)
                } else {
                    toastr.error(data.message)
                }
            },
            dataType: "json"
        })
    })

    createbtn.addEventListener("click", async function (e) {
        e.preventDefault();

        var plusOneCbx = document.getElementById("PlusOne")

        var Name = document.getElementById("Name").value
        var Surname = document.getElementById("Surname").value
        var Email = document.getElementById("Email").value
        var GuestID = document.getElementById("GuestID").innerText

        var formData = 
            "{\"Name\":\"" + Name + "\",\"Surname\":\"" + Surname+
            "\",\"Email\":\"" + Email + "\",\"GuestListId\":" + GuestID + ",\"RSVP\":"+ true
        

        if (plusOneCbx.checked == true) {
            var PlusOneName = document.getElementById("PlusOneName").value
            var PlusOneSurname = document.getElementById("PlusOneSurname").value
            formData = formData + ",\"PlusOne\":" + true
            formData = formData + ",\"PlusOneName\":\"" + PlusOneName
            formData = formData + "\",\"PlusOneSurname\":\"" + PlusOneSurname + "\"}"
        } else {
            formData = formData + ",\"PlusOne\":" + false + "}"
        }

        if (!isEmpty(formData)) {
            var formData = JSON.parse(formData) 
            console.log(formData)
            $.ajax({
                type: "POST",
                url: (window.location.origin + "/User/Invitations/CreateRSVP/" + GuestID),
                data: formData,
                success: async function (data) {
                    if (data.success) {
                        console.log("success")
                        window.location.href = (window.location.origin + "/User/Invitations/ViewInvitation/" + GuestID)
                    }
                    else {
                        console.log("fail")
                    }
                },
                dataType: "json",
                contentType: "application/json"
            });
        }

        console.log("done")
    })

    DeclineBtn.addEventListener("click", async function (e) {
        e.preventDefault();

        var plusOneCbx = document.getElementById("PlusOne")

        var Name = document.getElementById("Name").value
        var Surname = document.getElementById("Surname").value
        var Email = document.getElementById("Email").value
        var GuestID = document.getElementById("GuestID").innerText

        var formData =
            "{\"Name\":\"" + Name + "\",\"Surname\":\"" + Surname +
            "\",\"Email\":\"" + Email + "\",\"GuestListId\":" + GuestID 


        if (plusOneCbx.checked == true) {
            var PlusOneName = document.getElementById("PlusOneName").value
            var PlusOneSurname = document.getElementById("PlusOneSurname").value
            formData = formData + ",\"PlusOne\":" + true
            formData = formData + ",\"PlusOneName\":\"" + PlusOneName
            formData = formData + "\",\"PlusOneSurname\":\"" + PlusOneSurname + "\"}"
        } else {
            formData = formData + ",\"PlusOne\":" + false + "}"
        }

        if (!isEmpty(formData)) {
            var formData = JSON.parse(formData)
            //console.log(formData)
            $.ajax({
                type: "POST",
                url: (window.location.origin + "/User/Invitations/CreateRSVP/" + GuestID),
                data: formData,
                success: async function (data) {
                    if (data.success) {
                        console.log("success")
                        window.location.href = (window.location.origin + "/User/Invitations/ViewInvitation/" + GuestID)
                    }
                    else {
                        console.log("fail")
                    }
                },
                dataType: "json",
                contentType: "application/json"
            });
        }

        console.log("done")
    })

}, false);

async function PostRSVP(fData, listId) {
    console.log("PostRSVP")
    console.log(fData)
}

async function HandleSchedules(sched) {
    var formData = '[' + sched + ']'
    console.log(formData)
    $.ajax({
        type: "POST",
        url: (window.location.origin + "//User/Invitations/SchedulesJson"),
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

async function HandleNote(note) {
    var ID = -1
    if (!isEmpty(note)) {
        //console.log("handlenote")
        var formData = {
            "NoteValue": note
        };
        //console.log(formData)
        $.ajax({
            type: "POST",
            url: (window.location.origin + "//User/Invitations/NoteJson"),
            data: JSON.stringify(formData),
            dataType: "NoteItem",
            success: async function (data) {
                if (data.success) {
                    console.log("success")
                    //console.log(data.message)
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
        //console.log("handlenoteOnly")
        var formData = {
            "NoteValue": note
        };
        //console.log("ID: " + noteId)
        $.ajax({
            type: "POST",
            url: (window.location.origin + "//User/Invitations/NoteJson/" + noteId),
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
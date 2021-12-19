document.addEventListener('DOMContentLoaded', function (ev) {
    //console.log('loaded')
    AddGuests(document.getElementById("invId").innerText);
    //console.log('after guests')
    AddNotes(document.getElementById("invId").innerText);
    //console.log('after notes')

    var viewRSVP = document.getElementById("viewRSVP")
    var copy = document.getElementById("copy")
    var edit = document.getElementById("edit")

    viewRSVP.addEventListener("click", function (e) {
        window.location.href = (window.location.origin + "/User/Invitations/ViewRSVP/" + document.getElementById("invId").innerText)
    })
    copy.addEventListener("click", function (e) {
        var text = window.location.origin + "/User/Invitations/ViewInvitation/" + document.getElementById("invId").innerText
        navigator.clipboard.writeText(text).then(function () {
            alert('Link copied to clipboard!');
        }, function (err) {
            console.error('Async: Could not copy text: ', err);
        });
    })

    edit.addEventListener('click', function () {
        var id = document.getElementById("invId").innerText
        var user = document.getElementById("ownerEmail").innerText
        $.ajax({
            type: "POST",
            url: (window.location.origin + "/User/Invitations/EditInvitation/" + id + "/" + user),
            success: async function (data) {
                if (data.success) {
                    window.location.href = (window.location.origin + "/User/Invitations/Edit/" + id)
                } else {
                    console.log(data.message)
                    toastr.error("Error loading page");
                    alert(data.message)
                    console.log("fail")
                }
            },
            dataType: "json",
            contentType: "application/json"
        });
    })

    CheckAndResize()
    window.addEventListener("resize", CheckAndResize);
})

//console.log('rando')

async function AddGuests(listId) {
    //console.log(window.location.origin + "/User/Invitations/GetRSVPs/" + listId)
    $.ajax({
        type: "GET",
        url: (window.location.origin + "/User/Invitations/GetRSVPs/" + listId),
        success: async function (data) {
            if (data.success) {
                var idx = 0
                var content = "<ul>"
                for (let msg in data.message.value) {
                    if (data.message.value[msg].rsvp) {
                        idx += 1
                        if (data.message.value[msg].plusOne) {
                            idx += 1
                        }
                    }
                    content = content + ConvertGuestToLi(data.message.value[msg])
                    //console.log(data.message.value[msg])
                }
                var content = content + "</ul>"
                if (idx > 0) {
                    document.getElementById("GuestCount").innerText = "Confirmed: " + idx
                }
                document.getElementById("GuestListContainer").innerHTML = content
            }
            else {
                console.log("fail")
                //return data.message
            }
        },
        dataType: "json",
        contentType: "application/json"
    });
}


async function AddNotes(listId) {
    //console.log(window.location.origin + "/User/Invitations/GetNotes/" + listId)
    $.ajax({
        type: "GET",
        url: (window.location.origin + "/User/Invitations/GetNotes/" + listId),
        success: async function (data) {
            if (data.success) {
                var content = "<ul>"
                for (let msg in data.message.value) {
                    content = content + ConvertNoteToLi(data.message.value[msg])
                }
                var content = content + "</ul>"

                document.getElementById("NoteListContainer").innerHTML = content
            }
            else {
                console.log("fail")
                //return data.message
            }
        },
        dataType: "json",
        contentType: "application/json"
    });
}

function ConvertGuestToLi(Guest) {
    var owner = document.getElementById("ownerEmail").innerText
    var logged = document.getElementById("loggedMail").innerText
    var admin = false

    if (owner == logged) {
        admin = true
    }


    var plusOneData = ""
    var responseData = ""

    if (Guest.plusOne) {
        plusOneData = " & " + Normalize(Guest.plusOneName) + " " + Normalize(Guest.plusOneSurname)
    }

    if (Guest.rsvp) {
        responseData = "Coming"
    } else {
        responseData = "Not Coming"
    }
    var ret = "<li class=\"bg-gray\">" + Normalize(Guest["name"]) + " " + Normalize(Guest.surname) + plusOneData + "&emsp;-&emsp;" + responseData

    if (admin) {
        //console.log(Guest)
        ret = ret + "&emsp;<a style=\"cursor:pointer;right:1rem;position:absolute;\" onclick=\"DeleteGuest(" + Guest.id + ")\" href=\"#\" class=\" float-right btn btn-link\">Delete</a>"
    }

    ret = ret + "</li>"

    return ret
}

function DeleteGuest(id) {
    var confirmation = confirm('Are you sure you want to delete?')
    if (confirmation == true) {
        $.ajax({
            type: "DELETE",
            url: (window.location.origin + "/User/Invitations/DeleteGuest/" + id),
            success: async function (data) {
                if (data.success) {
                    console.log("success")
                    toastr.success("Deleted");
                    location.reload()
                }
                else {
                    console.log(data.message)
                    toastr.error("Problem Deleting");
                    console.log("fail")
                }
            },
            dataType: "json",
            contentType: "application/json"
        });
    }
}

function ConvertNoteToLi(Note) {
    return "<li>" + Normalize(Note["noteValue"]) + "</li>"
}

function Normalize(value) {
    return decodeURI(value).replace('/%20/g', " ")
}


function CheckAndResize() {
    const guestCount = document.getElementById("GuestCount");

    if (document.documentElement.clientWidth < 445) {
        guestCount.classList.add("float-right");
    }else {
        guestCount.classList.remove("float-right");
    }
}



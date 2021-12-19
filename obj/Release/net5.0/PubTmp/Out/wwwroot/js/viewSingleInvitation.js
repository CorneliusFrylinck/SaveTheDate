document.addEventListener('DOMContentLoaded', function (e) {
    CheckAndResize()
    window.addEventListener("resize", CheckAndResize);
}, false)

function CheckAndResize() {
    const rsvps = document.querySelectorAll(".rsvp");
    const wedding = document.querySelectorAll(".wedding");

    for (let i = 0; i < rsvps.length; i++) {
        rsvps[i].classList.remove("hidden");
    }
    for (let i = 0; i < wedding.length; i++) {
        wedding[i].classList.remove("hidden");
    }
    //var rsvpDate
    //var weddingDate

    if (document.documentElement.clientWidth < 470) {
        for (let i = 0; i < rsvps.length; i++) {
            rsvps[i].classList.add("hidden");
        }
    }
    if (document.documentElement.clientWidth < 385) {
        for (let i = 0; i < wedding.length; i++) {
            wedding[i].classList.add("hidden");
        }
    }
}

function getWidth() {
    /*console.log('document.body.scrollWidth: ' + document.body.scrollWidth)
    console.log('document.documentElement.scrollWidth: ' + document.documentElement.scrollWidth)
    console.log('document.body.offsetWidth: ' + document.body.offsetWidth)
    console.log('document.documentElement.offsetWidth,: ' + document.documentElement.offsetWidth,)
    console.log('document.documentElement.clientWidth: ' + document.documentElement.clientWidth)*/
    return Math.max(
        document.body.scrollWidth,
        document.documentElement.scrollWidth,
        document.body.offsetWidth,
        document.documentElement.offsetWidth,
        document.documentElement.clientWidth
    );
}

function DeleteRoute(id) {
    var confirmation = confirm('Are you sure you want to delete?')
    if (confirmation == true) {
        // TODO - Delete through Ajax
        console.log("Confirmation: " + confirmation)
        console.log("Id: " + id)
    }
}
function DetailsRoute(id) {
    window.location.href = (window.location.origin + "/User/Invitations/ViewInvitation/" + id)
}
function EditRoute(id) {
    // TODO - Go to Edit page through Ajax
}
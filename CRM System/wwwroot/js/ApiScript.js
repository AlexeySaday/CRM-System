function f() {
    alert("Ну пока fuck")
}
async function getMessage() {
    alert("Почти заебись");
    const response = await fetch("https://localhost:44319/api/request", {
        method: "GET",
        headers: { "Accept": "application/json" }
    });
    if (response.ok == true) {
        alert("Все заебись")
        const messages = await response.json();
        const rows = document.querySelector("tbody");
        messages.forEach(el => rows.append(row(el)));
    }
    else {
        alert("fuck")
    }
}
async function getMessage(id) {
    const response = await fetch(`https://localhost:44319/api/messages/${id}`, {
        method: "GET",
        headers: { "Accept": "application/json" }
    });
    if (response.ok == true) {
        const message = await response.json();
    }
}
function row(message) {

    const idTd = document.createElement("td");
    idTd.setAttribute("data-row-id", message.id);
    idTd.append(message.id);
    tr.append(idTd);

    const nameTd = document.createElement("td");
    nameTd.append(message.name);
    tr.append(nameTd);

    const textTd = document.createElement("td");
    textTd.append(message.messageText);
    tr.append(textTd); 
     
    //const linksTd = document.createElement("td");

    //const editLink = document.createElement("button");
    //editLink.append("Изменить");
    //editLink.addEventListener("click", async () => await getUser(user.id));
    //linksTd.append(editLink);

    //const removeLink = document.createElement("button");
    //removeLink.append("Удалить");
    //removeLink.addEventListener("click", async () => await deleteUser(user.id));

    //linksTd.append(removeLink);
    //tr.appendChild(linksTd);

    return tr;
}
async function getMessage() {
    const response = await fetch("https://localhost:44319/api/messages", {
        method: "GET",
        headers: { "Accept": "application/json" }
    });
    if (response.ok == true) {
        const messages = await response.json();
        const rows = document.querySelector("tbody");
        messages.forEach(el => rows.append(row(el)));
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

    const tr = document.createElement("tr");
    tr.setAttribute("data-rowid", message.id);

    const nameTd = document.createElement("td");
    nameTd.append(message.name);
    tr.append(nameTd);

    const textTd = document.createElement("td");
    textTd.append(message.text);
    tr.append(textTd);

    const linksTd = document.createElement("td");

    const editLink = document.createElement("button");
    editLink.append("Изменить");
    editLink.addEventListener("click", async () => await getUser(user.id));
    linksTd.append(editLink);

    const removeLink = document.createElement("button");
    removeLink.append("Удалить");
    removeLink.addEventListener("click", async () => await deleteUser(user.id));

    linksTd.append(removeLink);
    tr.appendChild(linksTd);

    return tr;
}
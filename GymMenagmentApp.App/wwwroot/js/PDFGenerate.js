
function DownloadPdf(filename, byteBase64) {
    debugger;
    console.log("javascript")
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octet-stream;base64," + byteBase64;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}

function ViewPdf(iframeId, byteBase64) {
    var link = documante.getElementById(iframeId).innerHTML = "";
    var ifrm = document.createElement('iframe');

    ifrm.setAttribute("src", "data:application/pdf;base64," + byteBase64);
    ifrm.style.width = "100%";
    ifrm.style.height = "600px";
    document.getElementById(iframeId).appendChild(ifrm);
}
function bla() {
    console.log("bla");
}
function table() {
    debugger;
    var doc = new jsPDF();

    doc.autoTable({ html: '#my-table' })

    doc.autoTable({
        head: [['Name', 'Email']],
        body: [['Bla', 'Bla']],
    })

    doc.save('table.pdf');
}

function downloadRtf(mimeType, base64String, fileName) {
    console.log("downloadRtf");
    var fileDataUrl = "data:" + mimeType + ";base64," + base64String;
    fetch(fileDataUrl).then(response => response.blob()).then(blob => {
        var link = window.document.createElement('a');
        link.href = window.URL.createObjectURL(blob, { mimeType });
        link.download = fileName;

        document.body.appendChild(link);
        link.click();
        document.body.removeChild(link);
    })
}

function downloadPdf(mimeType, base64String, fileName) {
    console.log("downloadPdff");
    var fileDataUrl = "data:" + mimeType + ";base64," + base64String;
    fetch(fileDataUrl).then(response => response.blob()).then(blob => {
        var link = window.document.createElement('a');
        link.href = window.URL.createObjectURL(blob, { mimeType });
        link.download = fileName;

        document.body.appendChild(link);
        link.click();
        document.body.removeChild(link);
    })
}
const clientId = "6931db15b8f74aad9a34d104d1a46554";
const viewerOptions = {
    embedMode: "LIGHT_BOX",
    showDownloadPDF: false,
    showPrintPDF: false
};

function fetchPDF(urlToPDF) {
    return new Promise((resolve) => {
        fetch(urlToPDF)
            .then((resolve) => resolve.blob())
            .then((blob) => {
                resolve(blob.arrayBuffer());
            })
    })
}

function showPDF(urlToPDF) {
    var adobeDCView = new AdobeDC.View({
        clientId: clientId
    });
    var previewFilePromise = adobeDCView.previewFile(
        {
            content: { promise: fetchPDF(urlToPDF) },
            metaData: { fileName: urlToPDF.split("/").slice(-1)[0] }
        },
        viewerOptions
    );
}

document.addEventListener("adobe_dc_view_sdk.ready", function () {
    document.getElementById("privacy").addEventListener("click", function () {
        showPDF("/PDF/Privacy.pdf")
    });
    document.getElementById("cookies").addEventListener("click", function () {
        showPDF("/PDF/Cookies.pdf")
    });
    document.getElementById("usage").addEventListener("click", function () {
        showPDF("/PDF/UsagePolicy.pdf")
    });
});
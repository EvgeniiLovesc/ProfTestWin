CKEDITOR.editorConfig = function (config) {
	config.toolbarGroups = [
		{ name: 'document', groups: ['mode', 'document', 'doctools'] },
		{ name: 'basicstyles', groups: ['basicstyles', 'cleanup'] },
		{ name: 'paragraph', groups: ['list', 'indent', 'blocks', 'align', 'bidi', 'paragraph'] },
		{ name: 'clipboard', groups: ['clipboard', 'undo'] },
		{ name: 'editing', groups: ['find', 'selection', 'spellchecker', 'editing'] },
		{ name: 'forms', groups: ['forms'] },
		{ name: 'links', groups: ['links'] },
		{ name: 'insert', groups: ['insert'] },
		{ name: 'colors', groups: ['colors'] },
		'/',
		{ name: 'styles', groups: ['styles'] },
		{ name: 'tools', groups: ['tools'] },
		{ name: 'others', groups: ['others'] },
		{ name: 'about', groups: ['about'] }
	];
	config.width = '100%';
	config.height = 480;
	config.resize_enabled = false;

	config.removeButtons = 'Image,Flash,Smiley,Iframe,Source,Save,NewPage,ExportPdf,Preview,Print,Templates,SelectAll,Scayt,Form,Checkbox,Radio,TextField,Textarea,Select,Button,ImageButton,HiddenField,RemoveFormat,CopyFormatting,CreateDiv,Indent,Outdent,Language,BidiRtl,BidiLtr,Anchor,PageBreak,Maximize,ShowBlocks,About,Replace,Find,Styles,Format,Font,FontSize,Table,Unlink,Link,SpecialChar';
};

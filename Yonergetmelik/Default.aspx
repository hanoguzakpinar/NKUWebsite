<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Yonergetmelik.Default" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	
		<div class="slider-container rev_slider_wrapper" style="height: 100vh; width:100%;">
					<div id="revolutionSlider" class="slider rev_slider" data-version="5.4.8" data-plugin-revolution-slider data-plugin-options="{'sliderLayout': 'fullscreen', 'delay': 9000, 'gridwidth': 1140, 'gridheight': 800, 'responsiveLevels': [4096,1200,992,500]}">
						<ul>
							<li class="slide-overlay" data-transition="fade">
								<img src="img/slides/slide-one-page-1-1.jpg"  
									alt=""
									data-bgposition="center center" 
									data-bgfit="cover" 
									data-bgrepeat="no-repeat" 
									class="rev-slidebg">

								<div class="tp-caption tp-resizeme"
									data-frames='[{"delay":1500,"speed":2000,"frame":"0","from":"opacity:0;x:-100%;y:-100%;","to":"o:1;x:0;y:0;","ease":"Power3.easeInOut"},{"delay":"wait","speed":300,"frame":"999","to":"opacity:0;fb:0;","ease":"Power3.easeInOut"}]'
								    data-type="image" 
									data-x="left" data-hoffset="['0','-150','-200','-200']"
									data-y="top" data-voffset="['-100','-150','-200','-200']"
								    data-width="['auto']"
								    data-height="['auto']"
								    data-basealign="slide"><img src="img/slides/slide-one-page-1-2.jpg" alt=""></div>

								<div class="tp-caption tp-resizeme"
									data-frames='[{"delay":1500,"speed":2000,"frame":"0","from":"opacity:0;x:100%;y:-100%;","to":"o:1;x:0;y:0;","ease":"Power3.easeInOut"},{"delay":"wait","speed":300,"frame":"999","to":"opacity:0;fb:0;","ease":"Power3.easeInOut"}]'
								    data-type="image" 
									data-x="right" data-hoffset="['0','-150','-200','-200']"
									data-y="top" data-voffset="['-100','-150','-200','-200']"
								    data-width="['auto']"
								    data-height="['auto']"
								    data-basealign="slide"><img src="img/slides/slide-one-page-1-3.jpg" alt=""></div>

								<div class="tp-caption tp-resizeme"
									data-frames='[{"delay":1500,"speed":2000,"frame":"0","from":"opacity:0;x:-100%;y:100%;","to":"o:1;x:0;y:0;","ease":"Power3.easeInOut"},{"delay":"wait","speed":300,"frame":"999","to":"opacity:0;fb:0;","ease":"Power3.easeInOut"}]'
								    data-type="image" 
									data-x="left" data-hoffset="['0','-150','-200','-200']"
									data-y="bottom" data-voffset="['-100','-150','-200','-200']"
								    data-width="['auto']"
								    data-height="['auto']"
								    data-basealign="slide"><img src="img/slides/slide-one-page-1-4.jpg" alt=""></div>

								<div class="tp-caption tp-resizeme"
									data-frames='[{"delay":1500,"speed":2000,"frame":"0","from":"opacity:0;x:100%;y:100%;","to":"o:1;x:0;y:0;","ease":"Power3.easeInOut"},{"delay":"wait","speed":300,"frame":"999","to":"opacity:0;fb:0;","ease":"Power3.easeInOut"}]'
								    data-type="image" 
									data-x="right" data-hoffset="['0','-150','-200','-200']"
									data-y="bottom" data-voffset="['-100','-150','-200','-200']"
								    data-width="['auto']"
								    data-height="['auto']"
								    data-basealign="slide"><img src="img/slides/slide-one-page-1-5.jpg" alt=""></div>

								<div class="tp-caption"
									data-x="center" data-hoffset="['-170','-170','-170','-365']"
									data-y="center" data-voffset="['-80','-80','-80','-105']"
									data-start="1000"
									data-transform_in="x:[-300%];opacity:0;s:500;"
									data-transform_idle="opacity:0.2;s:500;"><img src="img/slides/slide-title-border.png" alt=""></div>

								<div class="tp-caption text-color-light font-weight-normal"
									data-x="center"
									data-y="center" data-voffset="['-80','-80','-80','-105']"
									data-start="700"
									data-fontsize="['16','16','16','40']"
									data-lineheight="['25','25','25','45']"
									data-transform_in="y:[-50%];opacity:0;s:500;">NAMIK KEMAL ÜNİVERSİTESİ</div>

								<div class="tp-caption"
									data-x="center" data-hoffset="['170','170','170','365']"
									data-y="center" data-voffset="['-80','-80','-80','-105']"
									data-start="1000"
									data-transform_in="x:[300%];opacity:0;s:500;"
									data-transform_idle="opacity:0.2;s:500;"><img src="img/slides/slide-title-border.png" alt=""></div>

								<h1 class="tp-caption font-weight-extra-bold text-color-light negative-ls-1"
									data-frames='[{"delay":1000,"speed":2000,"frame":"0","from":"sX:1.5;opacity:0;fb:20px;","to":"o:1;fb:0;","ease":"Power3.easeInOut"},{"delay":"wait","speed":300,"frame":"999","to":"opacity:0;fb:0;","ease":"Power3.easeInOut"}]'
									data-x="center"
									data-y="center" data-voffset="['-30','-30','-30','-30']"
									data-fontsize="['50','50','50','90']"
									data-lineheight="['55','55','55','95']">ÖĞRENCİ İŞLERİ</h1>

								<div class="tp-caption"
									data-frames='[{"delay":2000,"speed":500,"frame":"0","from":"opacity:0;x:10%;","to":"opacity:1;x:0;","ease":"Power3.easeInOut"},{"delay":"wait","speed":300,"frame":"999","to":"opacity:0;fb:0;","ease":"Power3.easeInOut"}]'
									data-x="center" data-hoffset="['-40','-40','-40','-40']"
									data-y="center" data-voffset="['2','2','2','15']"><img src="img/slides/slide-blue-line-big.png" alt=""></div>

								<div class="tp-caption font-weight-light ws-normal text-center"
									data-frames='[{"from":"opacity:0;","speed":300,"to":"o:1;","delay":2000,"split":"chars","splitdelay":0.03,"ease":"Power2.easeInOut"},{"delay":"wait","speed":1000,"to":"y:[100%];","mask":"x:inherit;y:inherit;s:inherit;e:inherit;","ease":"Power2.easeInOut"}]'
									data-x="center"
									data-y="center" data-voffset="['53','53','53','105']"
									data-width="['530','530','530','1100']"
									data-fontsize="['18','18','18','40']"
									data-lineheight="['26','26','26','45']"
									style="color: #b5b5b5;"> </div>

								<a class="tp-caption btn btn-primary btn-rounded font-weight-semibold"
									data-frames='[{"delay":2500,"speed":2000,"frame":"0","from":"opacity:0;y:50%;","to":"o:1;y:0;","ease":"Power3.easeInOut"},{"delay":"wait","speed":300,"frame":"999","to":"opacity:0;fb:0;","ease":"Power3.easeInOut"}]'
									data-hash
									data-hash-offset="85"
									href="Login.aspx"
									data-x="center" data-hoffset="0"
									data-y="center" data-voffset="['133','133','133','255']"
									data-whitespace="nowrap"	
									data-fontsize="['14','14','14','33']"	
									data-paddingtop="['15','15','15','40']"
									data-paddingright="['45','45','45','110']"
									data-paddingbottom="['15','15','15','40']"				 
									data-paddingleft="['45','45','45','110']">KULLANICI GİRİŞİ</a>
							

							</li>
							
												
						</ul>
					</div>
				</div>

</asp:Content>
